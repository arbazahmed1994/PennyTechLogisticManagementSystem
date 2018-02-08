﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PennyTechManagementSystem.Models
{
    public static class ModelExtentions
    {

        public static IEnumerable<SelectListItem> ToDriverSelectListItems(
            this IEnumerable<Driver> DriverCode, string selectedCode)
        {
            return
                DriverCode.OrderBy(driver => driver.DriverName)
                      .Select(driver =>
                          new SelectListItem
                          {
                              Selected = (driver.DriverCode == selectedCode),
                              Text = driver.DriverName,
                              Value = driver.DriverCode.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToVehicleSelectListItems(
            this IEnumerable<VehicleModel> VehicleCode, string selectedCode)
        {
            return
                VehicleCode.OrderBy(vehicle => vehicle.VehicleNumber)
                      .Select(vehicle =>
                          new SelectListItem
                          {
                              Selected = (vehicle.VehicleCode == selectedCode),
                              Text = vehicle.VehicleNumber,
                              Value = vehicle.VehicleCode.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToCountrySelectListItems(
            this IEnumerable<BasicModel> Country, int selectedId)
        {
            return
                Country.OrderBy(country => country.CountryName)
                      .Select(country =>
                          new SelectListItem
                          {
                              Selected = (country.CountryID == selectedId),
                              Text = country.CountryName,
                              Value = country.CountryID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToStatusSelectListItems(
            this IEnumerable<BasicModel> Status, int selectedId)
        {
            return
                Status.OrderBy(status => status.StatusName)
                      .Select(status =>
                          new SelectListItem
                          {
                              Selected = (status.StatusID == selectedId),
                              Text = status.StatusName,
                              Value = status.StatusID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToVehicleTypeSelectListItems(
            this IEnumerable<VehicleType> VehicleType, int selectedId)
        {
            return
                VehicleType.OrderBy(vehicleType => vehicleType.VehicleTypeName)
                      .Select(vehicleType =>
                          new SelectListItem
                          {
                              Selected = (vehicleType.VehicleTypeID == selectedId),
                              Text = vehicleType.VehicleTypeName,
                              Value = vehicleType.VehicleTypeID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToVehicleBusinessTypeSelectListItems(
            this IEnumerable<VehicleBusinessType> VehicleBusinessType, int selectedId)
        {
            return
                VehicleBusinessType.OrderBy(vehicleBusinessType => vehicleBusinessType.VehicleBusinessTypeName)
                      .Select(vehicleBusinessType =>
                          new SelectListItem
                          {
                              Selected = (vehicleBusinessType.VehicleBusinessTypeID == selectedId),
                              Text = vehicleBusinessType.VehicleBusinessTypeName,
                              Value = vehicleBusinessType.VehicleBusinessTypeID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToVehicleCompanySelectListItems(
            this IEnumerable<VehicleCompany> VehicleCompany, int selectedId)
        {
            return
                VehicleCompany.OrderBy(vehicleCompany => vehicleCompany.VehicleCompanyName)
                      .Select(vehicleCompany =>
                          new SelectListItem
                          {
                              Selected = (vehicleCompany.VehicleCompanyID == selectedId),
                              Text = vehicleCompany.VehicleCompanyName,
                              Value = vehicleCompany.VehicleCompanyID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToColorSelectListItems(
            this IEnumerable<BasicModel> Color, int selectedId)
        {
            return
                Color.OrderBy(color => color.ColorName)
                      .Select(color =>
                          new SelectListItem
                          {
                              Selected = (color.ColorID == selectedId),
                              Text = color.ColorName,
                              Value = color.ColorID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToExpenceCategorySelectListItems(
            this IEnumerable<ExpenceCategoryModel> ExpenceCategory, int selectedId)
        {
            return
                ExpenceCategory.OrderBy(expenceCategory => expenceCategory.ExpenceCategoryName)
                      .Select(expenceCategory =>
                          new SelectListItem
                          {
                              Selected = (expenceCategory.ExpenceCategoryID == selectedId),
                              Text = expenceCategory.ExpenceCategoryName,
                              Value = expenceCategory.ExpenceCategoryID.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToExpenceNameSelectListItems(
            this IEnumerable<ExpenceNameModel> ExpenceName, int selectedId)
        {
            return
                ExpenceName.OrderBy(expenceName => expenceName.ExpenceName)
                      .Select(expenceName =>
                          new SelectListItem
                          {
                              Selected = (expenceName.ExpenceNameID == selectedId),
                              Text = expenceName.ExpenceName,
                              Value = expenceName.ExpenceNameID.ToString()
                          });
        }
    }
}