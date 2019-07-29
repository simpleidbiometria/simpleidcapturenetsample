using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSocketSharp;

namespace HTXSystems.SimpleIDCaptureNetSample.WF
{
    public class SimpleIDResponseEventArgs : EventArgs
    {
        public SimpleIDResponse SimpleIDResponse { get; set; }
    }

    public class SimpleID
    {
        private WebSocket _ws;
        private string _wsURL = "ws://localhost:7001/operations/";
        private string _apiKey = "7E55393D-0B8F-49D2-8E96-E2D82BB0E4B1";

        public event EventHandler<SimpleIDResponseEventArgs> onSimpleIDEvent;

        public void Connect()
        {
            _ws = new WebSocket(_wsURL);
            _ws.OnMessage += (sender, e) =>
            {
                var response = JsonConvert.DeserializeObject<SimpleIDResponse>(e.Data);
                FireEvent(new SimpleIDResponseEventArgs
                {
                    SimpleIDResponse = response
                });
            };
            _ws.Connect();
        }

        public void Disconnect()
        {
            _ws.Close();
        }

        public void StartRegister(string accountId, string personId, string custom1,
            string custom2, string custom3, string faceImage, bool faceOnly)
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.REGISTER);
            request.AccountID = accountId;
            request.PersonID = personId;
            request.CustomField1 = custom1;
            request.CustomField2 = custom2;
            request.CustomField3 = custom3;
            request.FaceImage = faceImage;
            request.FaceOnly = faceOnly;

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void SubmitRegister()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.SUBMIT_REGISTRATION);

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void CancelRegister()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.CANCEL_REGISTRATION);

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void Delete(string accountId, string personId)
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.DELETE);
            request.AccountID = accountId;
            request.PersonID = personId;

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void SearhFingerprint(string accountId, string personId)
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.SEARCH);
            request.AccountID = accountId;
            request.PersonID = personId;

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void CancelFingerprintSearch()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.CANCEL_SEARCH);
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void SearchFace(string accountId, string personId, string faceImage)
        {

            var request = new SimpleIDRequest(_apiKey, OperationType.SEARCH_FACE);
            request.PersonID = personId;
            request.AccountID = accountId;
            request.FaceImage = faceImage;

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void GetPersonByID(string accountId, string personId, string custom1)
        {

            var request = new SimpleIDRequest(_apiKey, OperationType.GET_PERSON_BY_ID);
            request.PersonID = personId;
            request.AccountID = accountId;
            request.CustomField1 = custom1;

            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void StartFingerCapture(FINGERID fingerId)
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.FINGER_START_CAPTURE);
            request.FingerID = fingerId;
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void StopFingerCapture()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.FINGER_STOP_CAPTURE);
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void DeleteCapturedFinger()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.DELETE_FINGER);
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void StartFaceAnalysis()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.INIT_FACE_ANALYSIS);
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void PerformFaceAnalysis(string faceImage)
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.PERFORM_FACE_ANALYSIS);
            request.FaceImage = faceImage;
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        public void StopFaceAnalysis()
        {
            var request = new SimpleIDRequest(_apiKey, OperationType.STOP_FACE_ANALYSIS);
            _ws.Send(JsonConvert.SerializeObject(request));
        }

        private void FireEvent(SimpleIDResponseEventArgs e)
        {
            onSimpleIDEvent?.Invoke(this, e);
        }
    }
}
