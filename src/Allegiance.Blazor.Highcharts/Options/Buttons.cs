﻿using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Buttons
    {
        [JsonProperty("contextButton", NullValueHandling = NullValueHandling.Ignore)]
        public ContextButton ContextButton { get; set; }

        public Buttons()
        {

        }

        public Buttons(bool? contextButtonEnabled = null)
        {
            ContextButton = new ContextButton(contextButtonEnabled);
        }
    }
}
