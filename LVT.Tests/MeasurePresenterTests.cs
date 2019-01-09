﻿using LVT.LVT.Services;
using NUnit.Framework;

namespace LVT.Tests
{
    class MeasurePresenterTests
    {
        private MeasurePresenter _measurePresenter;
        private Measure _testMeasure;

        [SetUp]
        public void SetupForTest()
        {
            _measurePresenter = new MeasurePresenter();
            _testMeasure = new Measure("testDescription", "testDeadline", 5, "testUnits");
        }

        [Test]
        public void EpicPresenterReturnsCorrectOrgChartString()
        {
            string parentNodeID = "Parent Initiative NodeID";

            string result = _measurePresenter.VisualizeToString(_testMeasure, parentNodeID);
            string expected = $"[{{ v:'{_testMeasure.NodeID}', f:'{_testMeasure.GetType().Name}<div style=\"font-style:italic\">{_testMeasure.Description}</div><div style=\"font-style:italic\">{_testMeasure.Deadline}</div><div style=\"font-style:italic\">{_testMeasure.Amount}</div><div style=\"font-style:italic\">{_testMeasure.Units}</div>'}}, '{parentNodeID}']";

            Assert.AreEqual(expected, result);
        }
    }
}
