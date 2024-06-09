namespace BusinessObjects.Models;

public class JewelryMaterial
{
    public int JewelryMaterialId { get; set; }
    public int JewelryId { get; set; }
    
    public int GoldPriceId { get; set; }
    
    public int StonePriceId { get; set; }
    
    public float GoldQuantity { get; set; }
    
    public float StoneQuantity { get; set; }
    
    public virtual StonePrice? StonePrice { get; set; }
    
    public virtual GoldPrice? GoldPrice { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
}