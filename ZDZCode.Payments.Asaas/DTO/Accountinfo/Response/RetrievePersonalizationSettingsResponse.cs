﻿namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public  class RetrievePersonalizationSettingsResponse
    {
        public string Object { get; set; }
        public string LogoBackgroundColor { get; set; }
        public string InfoBackgroundColor { get; set; }
        public string FontColor { get; set; }
        public bool? Enabled { get; set; }  
        public string LogoUrl { get; set; }
        public string Observations {  get; set; }
        public string Status { get; set; }
    }
}
