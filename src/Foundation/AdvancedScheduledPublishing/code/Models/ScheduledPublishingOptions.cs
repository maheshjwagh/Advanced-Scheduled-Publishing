﻿using System;
using System.Collections.Generic;
using Sitecore.Data.Items;

namespace Sitecore.Foundation.AdvancedScheduledPublishing.Models
{
    internal class ScheduledPublishingOptions
    {
        public ScheduledPublishingOptions()
        {
            Items = new List<Item>();
        }
        public bool EnablePublishingSchedule { get; set; }
        public DateTime PublishTime { get; set; }
        public List<Item> Items { get; set; }
        public DateTime? LastPublishing { get; set; }
    }
}