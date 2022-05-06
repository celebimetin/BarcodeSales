using System.ComponentModel;

namespace BarcodeSales
{
    enum BirimTipi
    {
        Adet,
        Kg,
        [Description("Açık Yiyecek")]
        AcikYiyecek,
        [Description("Açık İçecek")]
        AcikIcecek,
        [Description("Diğer")]
        Diger
    }
}