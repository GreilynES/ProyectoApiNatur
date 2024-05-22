using Entities;

namespace Services.Order
{
    public interface ISvOrder
    {
        public void Add_Order();

        public float Calculate_Total { get; set; }

        public void Send_Email();

        public Order_Confirmation Update_Confirmation { get; set; }

        List<Order_Confirmation> Order_Confirmation {  get; set; }
    }
}
