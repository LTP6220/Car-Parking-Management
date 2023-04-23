using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_ParkingCard
    {
        private DAL_ParkingCard parkingCardModel = new DAL_ParkingCard();

        public BUS_ParkingCard() { }
        public List<DTO_ParkingCard> GetParkingCards(string query)
        {
            return parkingCardModel.GetParkingCards(query);
        }
        public void AddParkingCard(string card_id, string slot_id, string car_number, string customer_id, DateTime check_in, DateTime check_out)
        {
            DTO_ParkingCard parkingCard = new DTO_ParkingCard();
            parkingCard.Car_id = card_id;
            parkingCard.Slot_id = slot_id;
            parkingCard.Car_number = car_number;
            parkingCard.Customer_id = customer_id;
            parkingCard.Check_in = check_in;
            parkingCard.Check_out = check_out;
            parkingCardModel.AddParkingCard(parkingCard);
        }

        public void AddParkingCardHour(string card_id, string slot_id, string car_number, string customer_id, DateTime check_in, DateTime? check_out)
        {
            parkingCardModel.AddParkingCardHour(card_id, slot_id, car_number, customer_id, check_in, check_out);
        }


        public void UpdateToParkingSlot(string slot_id, string car_id, DateTime check_in, DateTime check_out)
        {
            parkingCardModel.UpdateToParkingSlot(slot_id, car_id, check_in, check_out);
        }

        public void UpdateNullToParkingSlot(string slot_id, string car_id, DateTime? check_in, DateTime? check_out)
        {
            parkingCardModel.UpdateNullToParkingSlot(slot_id, car_id, check_in, check_out);
        }

        public void UpdateToParkingSlotHour(string slot_id, string car_id, DateTime check_in, DateTime? check_out)
        {
            parkingCardModel.UpdateToParkingSlotHour(slot_id, car_id, check_in, check_out);
        }

        public void UpdateAvailabilityToParkingSlot(string availability)
        {
            parkingCardModel.UpdateAvailabilityToParkingSlot(availability);
        }

        public void UpdateNotAvailabilityToParkingSlot(string availability)
        {
            parkingCardModel.UpdateNotAvailabilityToParkingSlot(availability);
        }
    }
}
