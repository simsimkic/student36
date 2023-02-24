/***********************************************************************
 * Module:  NotificationService.cs
 * Purpose: Definition of the Class Service.UserService.NotificationService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public class NotificationService
   {
      public Model.User.Notification ReadNotification(int id)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteNotification(int id)
      {
         // TODO: implement
      }
      
      public Model.User.Notification CreateNotification()
      {
         // TODO: implement
         return null;
      }
      
      public void NotifyObservers()
      {
         // TODO: implement
      }
      
      public void Subscribe(NotificationObserver observer)
      {
         // TODO: implement
      }
      
      public void Unsubscribe(NotificationObserver observer)
      {
         // TODO: implement
      }
   
      public Repository.UserRepository.NotificationRepository notificationRepository;
      public NotificationObserver[] notificationObserver;
   
   }
}