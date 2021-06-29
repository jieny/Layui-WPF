﻿using Layui.Core.Base;
using Layui.Core.Resource;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LayuiHome.ViewModels
{
    public class HomeViewModel : LayuiViewModelBase
    {
        public HomeViewModel(IRegionManager regionManager, IDialogService dialogServic) : base(regionManager, dialogServic)
        {
            MenuItemList = new ObservableCollection<object>();
            MenuItemList.Add(new
            {
                Title = "基本元素",
                Data = new ObservableCollection<object>()
                    {
                        new
                        {
                            ItemTitle="按钮", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="表单", PageKey=SystemResource.Page_FormView
                        },new
                        {
                            ItemTitle="基础菜单", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="选项卡", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="进度条", PageKey=SystemResource.Page_ProgressBar
                        },new
                        {
                            ItemTitle="面板", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="徽章", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="动画", PageKey=SystemResource.Page_ButtonView
                        }
                    }
            }); MenuItemList.Add(new
            {
                Title = "组件示例",
                Data = new ObservableCollection<object>()
                    {
                        new
                        {
                            ItemTitle="弹出层", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="日期与时间选择", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="数据表格", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="下拉菜单", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="文件上传", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="穿梭格", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="树形组件", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="滑块", PageKey=SystemResource.Page_Slider
                        },new
                        {
                            ItemTitle="评分", PageKey=SystemResource.Page_ButtonView
                        },new
                        {
                            ItemTitle="轮播图", PageKey=SystemResource.Page_ButtonView
                        }
                    }
            });

        }
        #region 视图属性
        private ObservableCollection<object> _MenuItemList;
        /// <summary>
        /// 导航目录
        /// </summary>
        public ObservableCollection<object> MenuItemList
        {
            get { return _MenuItemList; }
            set { _MenuItemList = value; }
        }
        #endregion
        #region 命令
        /// <summary>
        /// 导航界面
        /// </summary>
        public DelegateCommand<string> GoPageCommand => new DelegateCommand<string>(GoPage);
        #endregion

        #region 核心方法
        /// <summary>
        /// 跳转界面
        /// </summary>
        /// <param name="PageKey"></param>
        private void GoPage(string PageKey)
        {
            regionManager.RequestNavigate(SystemResource.Nav_HomeContent, PageKey);
        }
        #endregion



    }
}