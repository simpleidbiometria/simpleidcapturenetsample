using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTXSystems.SimpleIDCaptureNetSample.WF
{
    public partial class Main : Form
    {
        private SimpleID simpleId;
        private OperationType _currentOperation;
        public Main()
        {
            InitializeComponent();
            simpleId = new SimpleID();
            simpleId.onSimpleIDEvent += SimpleId_onSimpleIDEvent;
            simpleId.Connect();
        }

        private void SimpleId_onSimpleIDEvent(object sender, SimpleIDResponseEventArgs e)
        {
            ProcessSimpleIDResponse(e.SimpleIDResponse);
        }

        private void btDeletePerson_Click(object sender, EventArgs e)
        {
            var accountId = string.IsNullOrEmpty(tbAccountId.Text.Trim()) ? null : tbAccountId.Text;
            var personId = string.IsNullOrEmpty(tbPersonId.Text.Trim()) ? null : tbPersonId.Text;

            simpleId.Delete(accountId, personId);
        }

        private void btCancelSearchFingerprint_Click(object sender, EventArgs e)
        {
            simpleId.CancelFingerprintSearch();
            pbSearchFingerprint.Image = null;
        }

        private void btSearchFingerprint_Click(object sender, EventArgs e)
        {
            _currentOperation = OperationType.SEARCH;
            var accountId = string.IsNullOrEmpty(tbAccountId.Text.Trim()) ? null : tbAccountId.Text;
            var personId = string.IsNullOrEmpty(tbPersonId.Text.Trim()) ? null : tbPersonId.Text;

            simpleId.SearhFingerprint(accountId, personId);
            pbSearchFingerprint.Image = null;
        }

        private void ProcessSimpleIDResponse(SimpleIDResponse response)
        {
            WriteLog(response);
            var returnCode = response.TransactionInformation.ReturnCode;
            var responseType = response.TransactionInformation.ResponseType;

            if (responseType == ResponseType.FINGER_CAPTURE_STATUS)
            {
                var base64Image = response.TransactionInformation.Persons.First().FingerprintImage.Base64Image;
                using (var ms = new MemoryStream(Convert.FromBase64String(base64Image)))
                {
                    Image image = Image.FromStream(ms);
                    if (_currentOperation == OperationType.SEARCH)
                    {
                        pbSearchFingerprint.Image = image;
                    }
                    else if (_currentOperation == OperationType.REGISTER)
                    {
                        pbRegisterFingerprint.Image = image;
                        if (response.TransactionInformation.Persons.First().FingerprintImage.Finished)
                        {
                            btSubmitRegister.Invoke(new Action(() => btSubmitRegister.Enabled = true));
                        }
                    }
                }
            }

            if (responseType == ResponseType.PROCESSING_STATUS)
            {
                if (response.TransactionInformation.ProcessingStatus == ProcessingStatus.REGISTRATION_READY)
                {
                    gbFingers.Invoke(new Action(() => gbFingers.Enabled = true));
                    btCancelRegister.Invoke(new Action(() => btCancelRegister.Enabled = true));
                }
            }


        }

        private void WriteLog(SimpleIDResponse response)
        {
            var returnCode = response.TransactionInformation.ReturnCode;
            var responseType = response.TransactionInformation.ResponseType;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}: ", responseType.ToString());
            if (responseType == ResponseType.PROCESSING_STATUS)
            {
                sb.AppendFormat("{0} ", response.TransactionInformation.ProcessingStatus.ToString());
            }
            else
            {
                sb.AppendFormat("{0} ", returnCode.ToString());
            }
            if (returnCode == ReturnCode.HIT_CONFIRMED || returnCode == ReturnCode.ALREADY_ENROLLED)
            {
                sb.AppendFormat(" - {0}", response.TransactionInformation.Persons.First().PersonID);
            }

            lbLog.Invoke(new Action(() =>
            {
                if (lbLog.Items.Count > 10)
                    lbLog.Items.RemoveAt(0);
                lbLog.Items.Add(sb.ToString());
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
                lbLog.ClearSelected();
            }));
        }

        private void btLoadImageSearchFace_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JPEG (.jpg)|*.jpeg;*.jpg";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pbSearchFace.Image = img;
            }
        }

        private void btSearchFace_Click(object sender, EventArgs e)
        {
            if (pbSearchFace.Image == null)
            {
                MessageBox.Show("Please, load an image first");
            }
            else
            {
                var image = pbSearchFace.Image;
                string base64Image = null;
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    base64Image = Convert.ToBase64String(imageBytes);
                }
                _currentOperation = OperationType.SEARCH_FACE;
                var accountId = string.IsNullOrEmpty(tbAccountId.Text.Trim()) ? null : tbAccountId.Text;
                var personId = string.IsNullOrEmpty(tbPersonId.Text.Trim()) ? null : tbPersonId.Text;

                simpleId.SearchFace(accountId, personId, base64Image);
            }
        }

        private void btLoadImageRegisterFace_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JPEG (.jpg)|*.jpeg;*.jpg";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pbRegisterFace.Image = img;
                btRegisterFaceOnly.Enabled = true;
            }
        }

        private void btRegisterFaceOnly_Click(object sender, EventArgs e)
        {
            if (pbRegisterFace.Image == null)
            {
                MessageBox.Show("Please, load an image first");
            }
            else
            {
                var image = pbRegisterFace.Image;
                string base64Image = null;
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    base64Image = Convert.ToBase64String(imageBytes);
                }
                _currentOperation = OperationType.REGISTER;
                var accountId = string.IsNullOrEmpty(tbAccountId.Text.Trim()) ? null : tbAccountId.Text;
                var personId = string.IsNullOrEmpty(tbPersonId.Text.Trim()) ? null : tbPersonId.Text;
                var custom1 = string.IsNullOrEmpty(tbCustom1.Text.Trim()) ? null : tbCustom1.Text;
                var custom2 = string.IsNullOrEmpty(tbCustom2.Text.Trim()) ? null : tbCustom2.Text;
                var custom3 = string.IsNullOrEmpty(tbCustom3.Text.Trim()) ? null : tbCustom3.Text;

                simpleId.StartRegister(accountId, personId, custom1, custom2, custom3, base64Image, true);
            }
        }

        #region FINGER_CLICKS

        private void StartFingerCapture(FINGERID fingerId)
        {
            simpleId.StartFingerCapture(fingerId);
        }

        private void btRightThumb_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.RIGHT_THUMB);
        }

        private void btRightIndex_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.RIGHT_INDEX);
        }

        private void btRightMiddle_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.RIGHT_MIDDLE);
        }

        private void btRightRing_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.RIGHT_RING);
        }

        private void btRightLittle_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.RIGHT_LITTLE);
        }

        private void btLeftThumb_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.LEFT_THUMB);
        }

        private void btLeftIndex_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.LEFT_INDEX);
        }

        private void btLeftMiddle_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.LEFT_MIDDLE);
        }

        private void btLeftRing_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.LEFT_RING);
        }

        private void btLeftLittle_Click(object sender, EventArgs e)
        {
            StartFingerCapture(FINGERID.LEFT_LITTLE);
        }

        #endregion

        private void btStartRegister_Click(object sender, EventArgs e)
        {
            var image = pbRegisterFace.Image;
            string base64Image = null;
            if (image != null)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    base64Image = Convert.ToBase64String(imageBytes);
                }
            }

            _currentOperation = OperationType.REGISTER;
            var accountId = string.IsNullOrEmpty(tbAccountId.Text.Trim()) ? null : tbAccountId.Text;
            var personId = string.IsNullOrEmpty(tbPersonId.Text.Trim()) ? null : tbPersonId.Text;
            var custom1 = string.IsNullOrEmpty(tbCustom1.Text.Trim()) ? null : tbCustom1.Text;
            var custom2 = string.IsNullOrEmpty(tbCustom2.Text.Trim()) ? null : tbCustom2.Text;
            var custom3 = string.IsNullOrEmpty(tbCustom3.Text.Trim()) ? null : tbCustom3.Text;

            simpleId.StartRegister(accountId, personId, custom1, custom2, custom3, base64Image, false);
        }

        private void btSubmitRegister_Click(object sender, EventArgs e)
        {
            simpleId.SubmitRegister();
        }

        private void btCancelRegister_Click(object sender, EventArgs e)
        {
            simpleId.CancelRegister();
            ClearRegisterForm();
        }

        private void ClearRegisterForm()
        {
            tbCustom1.Text = tbCustom2.Text = tbCustom3.Text = "";
            pbRegisterFingerprint.Image = null;
            gbFingers.Enabled = false;
            btCancelRegister.Enabled = false;
            pbRegisterFace.Image = null;
            btRegisterFaceOnly.Enabled = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //IT IS VERY IMPORTANT TO CLOSE THE WEBSOCKET, OTHERWISE, IF SOME
            //OPERATION IS RUNNING ON SIMPLE ID CLIENT, THIS OPERATION WILL
            //CONTINUE TO RUN (FINGERPRINT SCANNER ON, FOR EXAMPLE)
            simpleId.Disconnect();
        }

        private void btClearRegister_Click(object sender, EventArgs e)
        {
            simpleId.CancelRegister();
            ClearRegisterForm();
        }
    }
}
