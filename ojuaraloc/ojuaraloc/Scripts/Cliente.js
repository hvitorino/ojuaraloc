(function () {
	window.App = !!window.App ? App : {};
	window.App.Models = !!window.App.Models ? App.Models : {};

	App.Models.Cliente = function () {
		var self = this;

		this.Id = ko.observable();
		this.Nome = ko.observable();
		this.Sobrenome = ko.observable();

		this.NomeCompleto = ko.computed(function () {
			return this.Nome() + " " + this.Sobrenome();
		}, this);

		this.salvar = function () {
			//monto a requisiçao ajax
			//envio o objeto

			$.post("Cliente/Inclui", ko.toJSON(self), function () {
				//post realizado com sucesso(inclusão também)
				for (var prop in self) {
					self[prop] = "";
				}
			});
			
		};
	};
})();
