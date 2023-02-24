/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.ManagerService.ManagerService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public class ManagerService
   {
      public Model.User.Notification SendValidationRequest(Dto.DTOValidationRequest dTOValidationRequest)
      {
         // TODO: implement
         return null;
      }

      // Izbacivalo je gresku posto je ova radnja bila apstraktna i sadrzana u neapstraktnoj klasi.
      // Zbog toga sam stavio da nije apstraktna.
      public void UpdateNotifications()
      {

      }
   
      public Repository.ManagerRepository.ManagerRepository managerRepository;
   
   }
}