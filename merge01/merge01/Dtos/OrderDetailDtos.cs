﻿using merge01.Models;

namespace merge01.Dtos
{
    public class OrderDetailDtos
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public int Quantity { get; set; }
        public string Delivery { get; set; }

        public long TransactionId { get; set; }
        public int Customer_Id { get; set; }
     //   public Customer Customer { get; set; }

        //   [ForeignKey("Meal_Id")]
        public int Meal_Id { get; set; }
        public List<MealDtos> Meal { get; set; }
    }
}
