using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject1.Models;
using WebApiProject1.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProject1.Repository
{
   public interface IPortRepository
    {
        //Task<List<PortUser>> GetAllPortusersAsync();
        //Task<Models.PortUser> GetPortusersByIdAsync(int PortId);
        Task<PortUser> AddPortUserAsync(PortUser PortuserModel);
        //Task UpdatePortusersAsync(int PortId, PortUser PortuserClass);
        //Task DeletePortusersAsync(int PortId);
        Task<List<PortSlot>> GetAvalSlotsAsync();
        Task UpdateSlot(int slotId, PortSlot slotsModel);
        //Task <IActionResult>AddPortUserAsync(PortUser portuserClass);
    }
}
