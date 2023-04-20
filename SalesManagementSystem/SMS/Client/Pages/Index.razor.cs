using Microsoft.JSInterop;
using SMS.Shared.DTO;
using SMS.Shared.Models;
using System.Net.Http.Json;

namespace SMS.Client.Pages
{
    public partial class Index
    {
        private string modalDisplay = "none;";
        private string modalClass = "";
        private bool showBackdrop = false;

        OrderDTO order = new();

        public void Open(int orderId)
        {
            GetOrderById(orderId);
            modalDisplay = "block;";
            Task.Delay(150);
            modalClass = "show";
            showBackdrop = true;
            StateHasChanged();
        }

        public void Close()
        {
            order = new();
            modalDisplay = "none";
            Task.Delay(150);
            modalClass = "";
            showBackdrop = false;
            StateHasChanged();
        }


        private List<OrderDTO> orders = new();


        private async Task Delete(OrderDTO order)
        {
            bool confirmed = await jsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                var result = await http.DeleteFromJsonAsync<Status>($"api/order/delete/{order.Id}");
                if (result.StatusCode == 1)
                    await GetOrders();

            }
        }

        private void GetOrderById(int orderId)
        {
            if (orderId > 0 && orders.Count > 0)
            {
                order = orders.FirstOrDefault(x => x.Id == orderId);
            }
        }

        private async Task GetOrders()
        {
            orders = await http.GetFromJsonAsync<List<OrderDTO>>($"api/order/getall");

        }

        protected override async Task OnInitializedAsync()
        {
            await GetOrders();
        }
    }
}
