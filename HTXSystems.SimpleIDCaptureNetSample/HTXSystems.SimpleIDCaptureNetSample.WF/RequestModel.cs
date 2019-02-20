using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTXSystems.SimpleIDCaptureNetSample.WF
{
    public enum OperationType
    {
        REGISTER = 0,
        SEARCH = 2,
        CANCEL_SEARCH = 3,
        DELETE = 4,
        GET_PERSON_BY_ID = 8,
        FINGER_START_CAPTURE = 9,
        FINGER_STOP_CAPTURE = 10,
        SUBMIT_REGISTRATION = 12,
        CANCEL_REGISTRATION = 13,
        DELETE_FINGER = 14,
        SEARCH_FACE = 15,
        INIT_FACE_ANALYSIS = 16,
        PERFORM_FACE_ANALYSIS = 17,
        STOP_FACE_ANALYSIS = 18,
        GET_CLIENT_VERSION = 19
    }

    public enum FINGERID
    {
        UNKNOWN,
        RIGHT_THUMB,
        RIGHT_INDEX,
        RIGHT_MIDDLE,
        RIGHT_RING,
        RIGHT_LITTLE,
        LEFT_THUMB,
        LEFT_INDEX,
        LEFT_MIDDLE,
        LEFT_RING,
        LEFT_LITTLE
    }

    public class SimpleIDRequest
    {
        [JsonProperty(PropertyName = "APIKey")]
        public string APIKey { get; set; }

        [JsonProperty(PropertyName = "Type")]
        public OperationType OperationType { get; set; }
        [JsonProperty(PropertyName = "AccountID")]
        public string AccountID { get; set; }

        [JsonProperty(PropertyName = "PersonID")]
        public string PersonID { get; set; }
        [JsonProperty(PropertyName = "CustomField1")]
        public string CustomField1 { get; set; }
        [JsonProperty(PropertyName = "CustomField2")]
        public string CustomField2 { get; set; }
        [JsonProperty(PropertyName = "CustomField3")]
        public string CustomField3 { get; set; }

        [JsonProperty(PropertyName = "FingerID")]
        public FINGERID FingerID { get; set; }

        [JsonProperty(PropertyName = "FaceImage")]
        public string FaceImage { get; set; }
        [JsonProperty(PropertyName = "FaceOnly")]
        public bool FaceOnly { get; set; }
        [JsonProperty(PropertyName = "IgnoreSearch")]
        public bool IgnoreSearch { get; set; }

        public SimpleIDRequest(string apiKey, OperationType operation)
        {
            APIKey = apiKey;
            OperationType = operation;
        }
    }
}
