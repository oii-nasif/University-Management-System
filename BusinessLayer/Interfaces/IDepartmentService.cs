﻿using UCRMS_API.Models;

namespace BusinessLayer.Interfaces
{
    public interface IDepartmentService
    {
        List<Department> GetList();
    }
}