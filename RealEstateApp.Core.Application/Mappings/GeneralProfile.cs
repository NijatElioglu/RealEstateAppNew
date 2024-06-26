﻿using AutoMapper;
using RealEstateApp.Core.Application.DTOs.Account;
using RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterAdminUser;
using RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterAgentUser;
using RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterBuyerUser;
using RealEstateApp.Core.Application.Features.Accounts.Commands.RegisterDeveloperUser;
using RealEstateApp.Core.Application.Features.Accounts.Queries.Authenticate;
using RealEstateApp.Core.Application.Features.Announcement.Commands.CreateAnnouncement;
using RealEstateApp.Core.Application.Features.Announcement.Commands.UpdateAnnouncement;
using RealEstateApp.Core.Application.Features.Category.Commands.CreateCategory;
using RealEstateApp.Core.Application.Features.Category.Commands.UpdateCategory;
using RealEstateApp.Core.Application.Features.Properties.Commands.CreateProperties;
using RealEstateApp.Core.Application.Features.TypeOfProperties.Commands.CreateTypeOfProperties;
using RealEstateApp.Core.Application.Features.TypeOfProperties.Commands.UpdateTypeOfProperties;
using RealEstateApp.Core.Application.Features.TypeOfSales.Commands.CreateTypeOfSales;
using RealEstateApp.Core.Application.Features.TypeOfSales.Commands.UpdateTypeOfSales;
using RealEstateApp.Core.Application.ViewModels.Admin;
using RealEstateApp.Core.Application.ViewModels.Announement;
using RealEstateApp.Core.Application.ViewModels.Categories;
using RealEstateApp.Core.Application.ViewModels.Properties;
using RealEstateApp.Core.Application.ViewModels.TypeOfProperties;
using RealEstateApp.Core.Application.ViewModels.TypeOfSales;
using RealEstateApp.Core.Application.ViewModels.Users;
using RealEstateApp.Core.Domain.Entities;

namespace RealEstateApp.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region UserProfile
            CreateMap<AuthenticationRequest, LoginViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, SaveUserViewModel>()
                .ForMember(x => x.File, opt => opt.Ignore())
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ForgotPasswordRequest, ForgotPasswordViewModel>()
               .ForMember(x => x.HasError, opt => opt.Ignore())
               .ForMember(x => x.Error, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();


            #endregion

            #region TypeOfPropertiesProfile
            CreateMap<TypeOfProperties, TypeOfPropertiesViewModel>()
               .ReverseMap()
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<TypeOfProperties, SaveTypeOfPropertiesViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            #endregion

            #region TypeOfSalesProfile
            CreateMap<TypeOfSales, TypeOfSalesViewModel>()
               .ReverseMap()
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<TypeOfSales, SaveTypeOfSalesViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            #endregion

            #region Properties

            CreateMap<Properties, SavePropertiesViewModel>()
              .ForMember(x => x.TypeOfProperties, opt => opt.Ignore())
              .ForMember(x => x.TypeOfSales, opt => opt.Ignore())
              .ForMember(x => x.ImageFileOne, opt => opt.Ignore())
              .ForMember(x => x.ImageFileTwo, opt => opt.Ignore())
              .ForMember(x => x.ImageFileThree, opt => opt.Ignore())
              .ForMember(x => x.ImageFileFour, opt => opt.Ignore())
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
              .ForMember(x => x.TypeOfProperty, opt => opt.Ignore())
              .ForMember(x => x.TypeOfSale, opt => opt.Ignore());

            CreateMap<PropertyDetailsViewModel, PropertiesViewModel>()
                .ReverseMap()
                .ForMember(x => x.AgentName, opt => opt.Ignore())
                .ForMember(x => x.AgentPhoneNumber, opt => opt.Ignore())
                .ForMember(x => x.AgentImagePath, opt => opt.Ignore())
                .ForMember(x => x.AgentEmail, opt => opt.Ignore());


            CreateMap<PropertiesViewModel, SavePropertiesViewModel>()
                .ReverseMap();


            CreateMap<UpdateAgentUserRequest, SaveAgentProfileViewModel>()
                .ReverseMap()
                .ForMember(x => x.UserName, opt => opt.Ignore());

            CreateMap<SaveAgentProfileViewModel, UpdateAgentUserResponse>()
               .ReverseMap()
                .ForMember(x => x.File, opt => opt.Ignore());


            CreateMap<Properties, PropertiesViewModel>()
             .ForMember(x => x.TypeOfProperty, opt => opt.Ignore())
             .ForMember(x => x.TypeOfSale, opt => opt.Ignore())
             .ReverseMap()
             .ForMember(x => x.Created, opt => opt.Ignore())
             .ForMember(x => x.CreatedBy, opt => opt.Ignore())
             .ForMember(x => x.LastModified, opt => opt.Ignore())
             .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
             .ForMember(x => x.TypeOfProperty, opt => opt.Ignore())
             .ForMember(x => x.TypeOfSale, opt => opt.Ignore());

            #endregion

            #region "User"
            CreateMap<UserViewModel, UpdateUserViewModel>()
             .ForMember(x => x.ConfirmPassword, opt => opt.Ignore())
             .ForMember(x => x.CurrentPassword, opt => opt.Ignore())
             .ForMember(x => x.Password, opt => opt.Ignore())
             .ForMember(x => x.Error, opt => opt.Ignore())
             .ForMember(x => x.HasError, opt => opt.Ignore())
             .ReverseMap()
             .ForMember(x => x.Role, opt => opt.Ignore());

            CreateMap<UpdateUserViewModel, SaveUserViewModel>()
             .ForMember(x => x.File, opt => opt.Ignore())
             .ForMember(x => x.Phone, opt => opt.Ignore())
             .ReverseMap();
            #endregion

            #region CQRS
            CreateMap<CreatePropertiesCommand, Properties>()
          .ForMember(x => x.Created, opt => opt.Ignore())
          .ForMember(x => x.CreatedBy, opt => opt.Ignore())
          .ForMember(x => x.LastModified, opt => opt.Ignore())
          .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
          .ReverseMap();
            CreateMap<CreateAnnouncementCommand, Announcement>()
          .ForMember(x => x.Created, opt => opt.Ignore())
          .ForMember(x => x.CreatedBy, opt => opt.Ignore())
          .ForMember(x => x.LastModified, opt => opt.Ignore())
          .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
          .ReverseMap();

            CreateMap<CreateTypeOfPropertiesCommand, TypeOfProperties>()
            .ForMember(x => x.Created, opt => opt.Ignore())
            .ForMember(x => x.CreatedBy, opt => opt.Ignore())
            .ForMember(x => x.LastModified, opt => opt.Ignore())
            .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
            .ReverseMap();


            CreateMap<CreateTypeOfSalesCommand, TypeOfSales>()
            .ForMember(x => x.Created, opt => opt.Ignore())
            .ForMember(x => x.CreatedBy, opt => opt.Ignore())
            .ForMember(x => x.LastModified, opt => opt.Ignore())
            .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
            .ReverseMap();

            CreateMap<UpdateTypeOfPropertiesCommand, TypeOfProperties>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<UpdateTypeOfPropertiesResponse, TypeOfProperties>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();



            CreateMap<TypeOfSalesUpdateCommand, TypeOfSales>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<TypeOfSalesUpdateResponse, TypeOfSales>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateCategoryCommand, Categories>()
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<UpdateCategoryResponse, Categories>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap(); 
            CreateMap<UpdateAnnouncementCommand, Announcement>()
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<UpdateAnnouncementResponse, Announcement>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateTypeOfPropertiesCommand, Properties>()
           .ForMember(x => x.Created, opt => opt.Ignore())
           .ForMember(x => x.LastModified, opt => opt.Ignore())
           .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
           .ForMember(x => x.CreatedBy, opt => opt.Ignore())
           .ReverseMap();

            CreateMap<UpdateTypeOfPropertiesResponse, Properties>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterAdminUserCommand, RegisterRequest>()
                .ReverseMap();
            CreateMap<RegisterBuyerUserCommand, RegisterRequest>()
                .ReverseMap();

            CreateMap<RegisterSellerUserCommand, RegisterRequest>()
               .ReverseMap();
            CreateMap<RegisterAgentUserCommand, RegisterRequest>()
         .ReverseMap();

            CreateMap<AuthenticateUserQuery, AuthenticationRequest>()
               .ReverseMap();

            #endregion

            #region Categories
            CreateMap<Categories, CategoriesViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Categories, SaveCategoriesViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<CreateCategoryCommand, Categories>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());
            #endregion


            #region Announcement
            CreateMap<Announcement, AnnouncementViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Announcement, SaveAnnouncementViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<CreateAnnouncementCommand, Announcement>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());
            #endregion
        }
    }
}
