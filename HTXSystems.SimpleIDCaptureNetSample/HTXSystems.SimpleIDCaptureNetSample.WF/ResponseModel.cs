using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTXSystems.SimpleIDCaptureNetSample.WF
{
    public enum ResponseType
    {
        FINGER_SCANNER_STATUS,
        FINGER_CAPTURE_STATUS,
        REGISTRATION_PROCESS_RESPONSE,
        SEARCH_PROCESS_RESPONSE,
        CANCEL_SEARCH_RESPONSE,
        SOCKET_GENERAL_MESSAGE,
        DELETE_RESPONSE,
        GET_PERSONS_BY_ID_RESPONSE,
        PROCESSING_STATUS,
        DUPLICATED_FINGER,
        GENERAL_MESSAGE,
        SEARCH_FACE_RESPONSE,
        INIT_FACE_ANALYSIS_RESPONSE,
        PERFORM_FACE_ANALYSIS_RESPONSE,
        STOP_FACE_ANALYSIS_RESPONSE,
        GET_CLIENT_VERSION_RESPONSE
    }

    public enum ReturnCode
    {
        SUCCESS = 0,
        CANCELED_BY_USER = 1,
        HIT_CONFIRMED = 2,
        NO_HIT = 3,
        ALREADY_ENROLLED = 4,
        CAPTURE_TIMEOUT = 5,
        BAD_IMAGE_QUALITY = 6,
        SERVICE_BUSY = 7,
        INCORRECT_CALL = 8,
        NO_READER_CONNECTED = -1,
        SERVER_CONNECTION_FAILED = -2,
        SERVER_TIMEOUT = -3,
        SERVER_ERROR = -4,
        PERSON_ID_NOT_FOUND = -5,
        INVALID_LICENSE = -6,
        LICENSE_MAX_RECORDS = -7,
        LICENSE_MAX_CLIENTS = -8,
        LICENSE_EXPIRED = -9,
        INVALID_APIKEY = -10,
        SESSION_EXPIRED = -11,
        NOT_ALLOWED_OPERATION = -12,
        INVALID_CREDENTIALS = -13,
        INVALID_PARAMETERS = -14,
        PARSER_ERROR = -17,
        FACE_MODULE_OPERATION_FAILED = -18,
        FACE_MODULE_NOT_INITIALIZED = -19,
        ACCOUNT_NOT_FOUND = -20,
        SERVER_NOT_READY = -21
    }


    public enum BrightnessLevel
    {
        TOO_DARK = -1,
        OK = 0,
        TOO_LIGHT = 1
    }

    public class Eye
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; }
    }

    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }

    public class FaceImageAnalysis
    {
        public Rectangle Rectangle { get; set; }
        public Rectangle CropRectangle { get; set; }
        public Eye RightEye { get; set; }
        public Eye LeftEye { get; set; }
        public int Yaw { get; set; }
        public int Pitch { get; set; }
        public int Roll { get; set; }
        public BrightnessLevel Brightness { get; set; }
        public bool Sharpness { get; set; }
        public bool MouthClosed { get; set; }
    }

    public class CapturedFingerprintImage
    {
        [JsonProperty(PropertyName = "Quality")]
        public int FingerQuality { get; set; }

        [JsonProperty(PropertyName = "Image")]
        public string Base64Image { get; set; }

        [JsonProperty(PropertyName = "FingerID")]
        public FINGERID FingerID { get; set; }

        [JsonProperty(PropertyName = "DuplicatedFingerID")]
        public FINGERID DuplicatedFingerID { get; set; }

        [JsonProperty(PropertyName = "Finished")]
        public bool Finished { get; set; }
    }

    public class PersonDTO
    {
        [JsonProperty(PropertyName = "PersonID")]
        public string PersonID { get; set; }
        [JsonProperty(PropertyName = "CustomField1")]
        public string CustomField1 { get; set; }
        [JsonProperty(PropertyName = "CustomField2")]
        public string CustomField2 { get; set; }
        [JsonProperty(PropertyName = "CustomField3")]
        public string CustomField3 { get; set; }

        [JsonProperty(PropertyName = "FingerprintImage")]
        public CapturedFingerprintImage FingerprintImage { get; set; }

        [JsonProperty(PropertyName = "FaceImageAnalysis")]
        public FaceImageAnalysis FaceImageAnalysis { get; set; }
        [JsonProperty(PropertyName = "FaceImage")]
        public string FaceImage { get; set; }
    }

    public class TransactionInformation
    {
        [JsonProperty(PropertyName = "Reason")]
        public ResponseType ResponseType { get; set; }

        [JsonProperty(PropertyName = "ReturnCode")]
        public ReturnCode ReturnCode { get; set; }

        [JsonProperty(PropertyName = "Message")]
        public string ReturnMessage { get; set; }

        [JsonProperty(PropertyName = "TransacationID")]
        public string TransacationID { get; set; }

        [JsonProperty(PropertyName = "AccountID")]
        public string AccountID { get; set; }

        [JsonProperty(PropertyName = "ProcessingStatus")]
        public ProcessingStatus ProcessingStatus { get; set; }

        [JsonProperty(PropertyName = "Persons")]
        public List<PersonDTO> Persons { get; set; }
    }

    public class SimpleIDResponse
    {
        [JsonProperty(PropertyName = "TransactionInformation")]
        public TransactionInformation TransactionInformation { get; set; }
    }

    public enum ProcessingStatus
    {
        LOCAL_PROCESSING,
        FINISHED_LOCAL_PROCESSING,
        SERVER_PROCESSING,
        FINISHED_SERVER_PROCESSING,
        REGISTRATION_READY,
        PENDING_FINGER_UP,
        PREPARING_SCANNER,
        SCANNER_READY,
        FINGER_DOWN,
        FINGER_UP,
        SCANNER_DISCONNECTED,
        SCANNER_CONNECTED
    }
}
