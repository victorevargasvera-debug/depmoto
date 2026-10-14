using System;
using System.Windows.Input;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003E RID: 62
	public class RelayCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00006A40 File Offset: 0x00004C40
		public RelayCommand(global::System.Action<object> execute) : this(execute, null)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00006A4A File Offset: 0x00004C4A
		public RelayCommand(global::System.Action<object> execute, global::System.Predicate<object> canExecute)
		{
			if (execute == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.execute = execute;
			this.canExecute = canExecute;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006A69 File Offset: 0x00004C69
		public bool CanExecute(object parameter)
		{
			return this.canExecute == null || this.canExecute(parameter);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000206 RID: 518 RVA: 0x00006A81 File Offset: 0x00004C81
		// (remove) Token: 0x06000207 RID: 519 RVA: 0x00006A89 File Offset: 0x00004C89
		public event global::System.EventHandler CanExecuteChanged
		{
			add
			{
				global::System.Windows.Input.CommandManager.RequerySuggested += value;
			}
			remove
			{
				global::System.Windows.Input.CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006A91 File Offset: 0x00004C91
		public void Execute(object parameter)
		{
			this.execute(parameter);
		}

		// Token: 0x040001AC RID: 428
		private readonly global::System.Action<object> execute;

		// Token: 0x040001AD RID: 429
		private readonly global::System.Predicate<object> canExecute;
	}
}
