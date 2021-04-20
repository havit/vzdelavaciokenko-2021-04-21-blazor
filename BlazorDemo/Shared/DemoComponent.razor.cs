using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Shared
{
	public sealed partial class DemoComponent : ComponentBase, IDisposable, IAsyncDisposable
	{
		[Inject] private ILogger<DemoComponent> Logger { get; set; }

		[Parameter] public int Value { get; set; }

		// ctor...

		public override async Task SetParametersAsync(ParameterView parameters)
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(SetParametersAsync) + " - start");
			await base.SetParametersAsync(parameters); // watch: parameters.ToDictionary()
			Logger.LogInformation(GetHashCode() + " " + nameof(SetParametersAsync) + " - end");
		}

		protected override void OnInitialized()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnInitialized));
			base.OnInitialized();
		}

		protected override async Task OnInitializedAsync()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnInitializedAsync));
			await base.OnInitializedAsync();
		}

		protected override void OnParametersSet()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnParametersSet));
			base.OnParametersSet();
		}

		protected override async Task OnParametersSetAsync()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnParametersSetAsync));
			await base.OnParametersSetAsync();
		}

		protected override bool ShouldRender()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(ShouldRender));
			return base.ShouldRender();
		}

		protected override void OnAfterRender(bool firstRender)
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnAfterRender));
			base.OnAfterRender(firstRender);
		}

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(OnAfterRenderAsync));
			return base.OnAfterRenderAsync(firstRender);
		}

		public void Dispose()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(Dispose));
		}

		public ValueTask DisposeAsync()
		{
			Logger.LogInformation(GetHashCode() + " " + nameof(DisposeAsync));
			return ValueTask.CompletedTask;
		}
	}
}
