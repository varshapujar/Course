using System;
using System.Collections.Generic;
using System.Text;

namespace Techademy.Assignment.Utility
{
    class TestData
    {
        private static TestData instance;

        public static TestData getInstance()
        {
            if (instance == null)
            {
                instance = new TestData();
            }
            return instance;
        }

        public void closeInstance()
        {
            instance = null;
        }
        public string Url = "https://www.airasia.com/en/gb";
        public string expectedSearchResults = "Leeds";
        public string linkFundSolutionsUrl = "https://www.linkfundsolutions.co.uk/";
        public string expectedFundForUK = "UK";
        public string expectedFundForSwiss = "Swiss";
    }
}
