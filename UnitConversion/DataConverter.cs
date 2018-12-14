namespace UnitConversion
{
    using UnitConversion.Base;

    /// <summary>
    /// Converts between data units.
    /// </summary>
    public class DataConverter : BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("mb")
        {
            { new UnitFactorSynonyms("mb" , "megabyte"), 1 },
            { new UnitFactorSynonyms("kb" , "kilobyte"), 1024 },
        };

        public DataConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public DataConverter()
        {
            Instantiate(units);
        }
    }
}
