﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Shared.Models
{
    public class ExternalPriceModel
    {
        [JsonIgnore]
        [IgnoreMember]
        public long? Id { get; set; }
        [JsonPropertyName("uuid")]
        [Key("uuid")]
        public string ClientId { get; set; }
        [Key("name")]
        public string Name { get; set; }
        [Key("calculated")]
        public double? Calculated { get; set; }
        [Key("max")]
        public double? Max { get; set; }
        [Key("mean")]
        public double? Mean { get; set; }
        [Key("median")]
        public double? Median { get; set; }
        [Key("min")]
        public double? Min { get; set; }
        [Key("mode")]
        public double? Mode { get; set; }
        [Key("frameType")]
        public int? FrameType { get; set; }
        [Key("variant")]
        public string Variant { get; set; }
        [Key("elder")]
        public bool? Elder { get; set; }
        [Key("shaper")]
        public bool? Shaper { get; set; }
        [Key("baseType")]
        public string BaseType { get; set; }
        [Key("links")]
        public int? Links { get; set; }
        [Key("quality")]
        public int? Quality { get; set; }
        [Key("ilvl")]
        public int? Ilvl { get; set; }
        [Key("level")]
        public int? Level { get; set; }
        [Key("corrupted")]
        public bool? Corrupted { get; set; }
        [Key("totalStacksize")]
        public int? TotalStacksize { get; set; }
        [Key("icon")]
        public string Icon { get; set; }
        [Key("tier")]
        public int? Tier { get; set; }
        [Key("count")]
        public int Count { get; set; }
        [Key("detailsUrl")]
        public string DetailsUrl { get; set; }
        [Key("customPrice")]
        public double? CustomPrice { get; set; }
    }
}