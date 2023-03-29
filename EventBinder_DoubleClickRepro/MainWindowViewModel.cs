using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBinder_DoubleClickRepro;

public sealed class MainWindowViewModel : ReactiveObject
{
	public void ButtonClicked()
	{
		Counter++;
	}

	private int _counter = 0;
	public int Counter
	{
		get => _counter;
		set => this.RaiseAndSetIfChanged(ref _counter, value);
	}
}
