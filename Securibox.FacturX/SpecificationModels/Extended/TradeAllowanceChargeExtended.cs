namespace Securibox.FacturX.SpecificationModels.Extended
{
    public class TradeAllowanceChargeExtended : BasicWL.TradeAllowanceCharge
    {
        public string SequenceNumeric { get; set; }
        public Basic.Quantity BasisQuantity { get; set; }
    }
}