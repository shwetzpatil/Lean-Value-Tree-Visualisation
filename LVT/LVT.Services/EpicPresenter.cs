﻿using LVT.LVT.Interfaces;
using System;
using System.Collections.Generic;

namespace LVT.LVT.Services
{
    public class EpicPresenter : IVisualizer<Epic> 

    {
        protected List<string[]> epicRowData = new List<string[]>();
        

        public string VisualizeToString(Epic epic, string parentNode)
        {
            return "[{ v: '" + epic.NodeID + "', f: 'Epic" + "<div style=\"font-style:italic\">" + $"{epic.Description}" + "</div>" +
                                                                                   "<div style=\"font-style:italic\">" + $"{epic.Deadline}" + "</div>" +
                                                                                   "'}, " + $"'{parentNode}']";
        }       
    }
}