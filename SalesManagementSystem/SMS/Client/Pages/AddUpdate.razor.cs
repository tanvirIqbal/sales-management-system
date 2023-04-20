using Microsoft.AspNetCore.Components;
using SMS.Shared.DTO;
using SMS.Shared.Models;
using System.Net.Http.Json;

namespace SMS.Client.Pages
{
    public partial class AddUpdate
    {
        private string modalDisplay = "none;";
        private string modalClass = "";
        private bool showBackdrop = false;
        [Parameter]
        public int Id { get; set; }

        private string Title = "Add order";
        private string WindowModalTitle = "Add Window";
        private string messageClass = "";
        private string modalMessageClass = "";
        OrderDTO order = new();
        WindowDTO window = new();
        SubElementDTO subElementDTO = new();
        Status? status = new();
        Status? modalStatus = new();
        private async Task Save()
        {
            try
            {
                if (string.IsNullOrEmpty(order.Name))
                {
                    status.Message = "Give order a name.";
                    messageClass = "text-danger";
                    return;
                }
                if (order.Windows == null || order.Windows.Count <= 0)
                {
                    status.Message = "Add at least one window";
                    messageClass = "text-danger";
                    return;
                }

                status.StatusCode = 0;
                status.Message = "Wait.....";
                var response = await http.PostAsJsonAsync("api/order/addupdate", order);
                status = await response.Content.ReadFromJsonAsync<Status>();
                messageClass = status.StatusCode == 1 ? "text-success" : "text-danger";
            }
            catch (Exception ex)
            {

            }

        }

        private void AddWindow()
        {
            if (string.IsNullOrEmpty(window.Name))
            {
                modalStatus.Message = "Give window a name.";
                modalMessageClass = "text-danger";
                return;
            }
            if (window.QuantityOfWindows <= 0)
            {
                modalStatus.Message = "Add quantity number of window.";
                modalMessageClass = "text-danger";
                return;
            }
            if (window.SubElements.Count <= 0)
            {
                modalStatus.Message = "Add at least one sub element.";
                modalMessageClass = "text-danger";
            }
            modalStatus = new();
            modalMessageClass = string.Empty;
            if (window.Id > 0)
            {
                status.Message = "Window updated.";
            }
            else
            {
                order.Windows.Add(window);
                status.Message = "Window added.";
            }

            window = new();

            messageClass = "text-success";
            Close();
        }

        private void DeleteWindow(WindowDTO window)
        {
            window.IsDeleted = true;
            status.Message = "Window removed";
            messageClass = "text-success";
        }

        protected override async Task OnInitializedAsync()
        {
            order = new();
            window = new();
            if (Id > 0)
            {
                Title = "Edit Order";
                order = await http.GetFromJsonAsync<OrderDTO>($"api/order/getbyid/{Id}");
            }
        }

        public void Open(int windowId)
        {
            if (order != null && string.IsNullOrEmpty(order.Name))
            {
                status.Message = "Give order a name.";
                messageClass = "text-danger";
                return;
            }
            GetWindowById(windowId);
            modalDisplay = "block;";
            Task.Delay(150);
            modalClass = "show";
            showBackdrop = true;
            StateHasChanged();
        }

        public void Close()
        {
            modalDisplay = "none";
            Task.Delay(150);
            modalClass = "";
            showBackdrop = false;
            StateHasChanged();
        }
        private void GetWindowById(int windowId)
        {
            window = new();
            if (windowId > 0 && order != null && order.Windows != null && order.Windows.Count > 0)
            {
                WindowModalTitle = "Edit Window";
                window = order.Windows.FirstOrDefault(x => x.Id == windowId);
            }
        }

        private void AddSubElement()
        {
            if (string.IsNullOrEmpty(window.Name))
            {
                modalStatus.Message = "Give window a name.";
                modalMessageClass = "text-danger";
                return;
            }
            if (window.QuantityOfWindows <= 0)
            {
                modalStatus.Message = "Add quantity number of window.";
                modalMessageClass = "text-danger";
                return;
            }
            if (subElementDTO.Element <= 0)
            {
                modalStatus.Message = "Add element number.";
                modalMessageClass = "text-danger";
                return;
            }
            if (subElementDTO.Width <= 0)
            {
                modalStatus.Message = "Width must be greater than 0.";
                modalMessageClass = "text-danger";
                return;
            }
            if (subElementDTO.Height <= 0)
            {
                modalStatus.Message = "Height must be greater than 0.";
                modalMessageClass = "text-danger";
                return;
            }
            window.TotalSubElements++;
            window.SubElements.Add(subElementDTO);
            subElementDTO = new();
            modalStatus = new();
            modalMessageClass = string.Empty;
        }

        private void DeleteSubElement(SubElementDTO subElementDTO)
        {
            window.TotalSubElements--;
            subElementDTO.IsDeleted = true;
            //window.SubElements.Remove(subElementDTO);
        }
    }
}
