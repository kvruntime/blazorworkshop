using Microsoft.AspNetCore.Components;

namespace BlazorIntro.Components.UI;
public partial class Delay : ComponentBase, IDisposable
{
  [Parameter] public double TimeInSeconds { get; set; }
  [Parameter] public EventCallback Tick { get; set; } = default!;
  Timer timer = default!;
  protected override void OnInitialized()
  {
    timer = new(
      callback: async (_) => InvokeAsync(async() => await Tick.InvokeAsync()),
      state: null,
      dueTime: TimeSpan.FromSeconds(TimeInSeconds),
      period: Timeout.InfiniteTimeSpan
    );
  }
  public void Dispose() => timer.Dispose();
}