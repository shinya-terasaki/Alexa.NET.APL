﻿using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response.APL;
using Newtonsoft.Json;

namespace Alexa.NET.APL.Components
{
    public class Frame:APLComponent
    {
        public const string ComponentType = "Frame";

        public override string Type => ComponentType;

        [JsonProperty("backgroundColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BackgroundColor { get; set; }

        [JsonProperty("borderBottomLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> BorderBottomLeftRadius { get; set; }

        [JsonProperty("borderBottomRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> BorderBottomRightRadius { get; set; }

        [JsonProperty("borderColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> BorderColor { get; set; }

        [JsonProperty("borderRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> BorderRadius { get; set; }

        [JsonProperty("borderTopLeftRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> BorderTopLeftRadius { get; set; }

        [JsonProperty("borderTopRightRadius",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<Dimension> BorderTopRightRadius { get; set; }

        [JsonProperty("borderWidth",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> BorderWidth { get; set; }

        [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<APLComponent>> Item { get; set; }
    }
}
