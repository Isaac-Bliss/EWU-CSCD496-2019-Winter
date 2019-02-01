﻿using System.Collections.Generic;
using SecretSanta.Domain.Services;
using SecretSanta.Domain.Models;

namespace SecretSanta.Api.Tests
{
    public class TestableGiftService : IGiftService
    {
        public Gift ToReturnAddGift { get; set; }
        public int AddGiftToUser_UserId { get; set; }
        public Gift AddGiftToUser_Gift { get; set; }
        public Gift AddGiftToUser(int userId, Gift gift)
        {
            AddGiftToUser_UserId = userId;
            AddGiftToUser_Gift = gift;
            return ToReturnAddGift;
        }


        public List<Gift> ToReturn { get; set; }
        public int GetGiftsForUser_UserId { get; set; }
        public List<Gift> GetGiftsForUser(int userId)
        {
            GetGiftsForUser_UserId = userId;
            return ToReturn;
        }


        public Gift RemoveGiftToUser_Gift { get; set; }
        public Gift ToReturnRemoveGift { get; set; }
        public Gift RemoveGift(Gift gift)
        {
            RemoveGiftToUser_Gift = gift;
            return ToReturnRemoveGift;
        }


        public Gift ToReturnUpdateGift { get; set; }
        public int UpdateGiftToUser_UserId { get; set; }
        public Gift UpdateGiftToUser_Gift { get; set; }
        public Gift UpdateGiftForUser(int userId, Gift gift)
        {
            UpdateGiftToUser_UserId = userId;
            UpdateGiftToUser_Gift = gift;
            return ToReturnUpdateGift;
        }
    }
}