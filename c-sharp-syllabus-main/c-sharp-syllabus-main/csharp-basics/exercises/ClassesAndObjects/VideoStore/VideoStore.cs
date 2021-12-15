using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        public List<Video> VideoList;

        public VideoStore()
        {
            VideoList = new List<Video>();
        }

        public void AddVideo(string title)
        {
            VideoList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (var item in VideoList)
            {
                if(item.Title == title)
                {
                    item.BeingCheckedOut();
                    break;
                }
            }
        }

        public void ReturnedVideo(string title)
        {
            foreach(var item in VideoList)
            {
                if(item.Title == title)
                {
                    item.BeingReturned();
                    break;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach(var item in VideoList)
            {
                if(item.Title == title)
                {
                    item.ReceivingRating(rating);
                }
            }
        }

        public void ListInventoryV()
        {
            foreach (Video film in VideoList)
            {
                Console.Write(film.ToString() + " ");
            }
        }
    }
}
