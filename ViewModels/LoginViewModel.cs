using System;
using System.Windows;
using System.Windows.Input;

namespace ComputerClubDiplom.ViewModels
{
	public class LoginViewModel
	{
		public string Email { get; set; }
		public ICommand LoginCommand { get; }
		public ICommand RegisterCommand { get; }

		public LoginViewModel()
		{
			LoginCommand = new RelayCommand(Login);
		}

		private void Login()
		{
			// Заглушка для логики авторизации
			MessageBox.Show($"Попытка входа с Логином: {Email}");
			// Позже добавим вызов сервиса авторизации
		}
	}

	// Временная реализация RelayCommand
	public class RelayCommand : ICommand
	{
		private readonly Action _execute;
		public event EventHandler CanExecuteChanged;

		public RelayCommand(Action execute)
		{
			_execute = execute;
		}

		public bool CanExecute(object parameter) => true;
		public void Execute(object parameter) => _execute();
	}
}
