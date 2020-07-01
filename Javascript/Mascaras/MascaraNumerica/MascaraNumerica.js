class MascaraNumerica {
	constructor(elemento) {
		this._elemento = elemento;
		this._elementoResultado = elemento;

		if (!this._elemento) return;

		if (this._elemento.id.indexOf('_Mascara') >= 0) {
			console.log(this._elemento.id + '_Mascara');
			this._elemento = null;
			return;
		}

		if (this._elemento.type == 'number') {
			this._elemento.type = 'tel';
		}

		this._opcoes = {
			precisao: 0,
			separador: ',',
			delimitador: '.',
			prefixo: '',
			sufixo: '',
			valorAtual: 0,
			tamanhoCampo: 0,
			ehVirtualizarCampo: true,
			ehEstiloCalculadora: false
		};

		this._controle = {
			baseValor: '',
			baseInteiro: '',
			baseFracao: '',
			negativo: false,
			posicaoDecimal: 0,
			posicaoCursor: 0,
			tamanhoCampo: 0
		}

		let dados = Array.from(elemento.attributes).find(attr => { return /^data-mascara/.test(attr.nodeName); }).value;

		if (dados) {
			let opt = JSON.parse(dados);
			this.parametros(opt);
		}

		if (this._elemento.attributes.maxlenght) {
			let atributoTamanhoCampo = parseInt(elemento.attributes.maxlenght.value);
			if (atributoTamanhoCampo && this._opcoes.tamanhoCampo == 0 && atributoTamanhoCampo > 0) this._opcoes.tamanhoCampo = atributoTamanhoCampo;
		}

		if (this._opcoes.ehVirtualizarCampo) this._campoVirtual();
		this._inicializacao();
		this._controleElemento(elemento);
	}

	parametros(opt) {
		if (!this._elemento) return;

		if (opt) {
			if (opt.precisao) this._opcoes.precisao = opt.precisao;
			if (opt.separador) this._opcoes.separador = opt.separador;
			if (opt.delimitador) this._opcoes.delimitador = opt.delimitador;
			if (opt.prefixo) this._opcoes.prefixo = opt.prefixo;
			if (opt.sufixo) this._opcoes.sufixo = opt.sufixo;
			if (opt.valorAtual) this._opcoes.valorAtual = opt.valorAtual;
			if (opt.tamanhoCampo) this._opcoes.tamanhoCampo = opt.tamanhoCampo;
			if (opt.ehVirtualizarCampo) this._opcoes.ehVirtualizarCampo = opt.ehVirtualizarCampo;
			if (opt.ehEstiloCalculadora) this._opcoes.ehEstiloCalculadora = opt.ehEstiloCalculadora;

			if (this._elemento.attributes.maxlenght) {
				let atributoTamanhoCampo = parseInt(this._elemento.attributes.maxlenght.value);
				if (atributoTamanhoCampo && this._opcoes.tamanhoCampo == 0 && atributoTamanhoCampo > 0) this._opcoes.tamanhoCampo = atributoTamanhoCampo;
			}

			this._inicializacao();
			this._ajustaValorEntrada();
		}
	}

	_inicializacao() {
		this._controle.posicaoDecimal = this._opcoes.precisao + this._opcoes.separador.length;
		if (this._opcoes.precisao == 0) this._controle.posicaoDecimal = 0;
		this._controle.posicaoCursor = 0;
		this._controle.tamanhoCampo = this._opcoes.tamanhoCampo;
		if (this._opcoes.tamanhoCampo > 15) this._controle.tamanhoCampo = 15;
		if (this._opcoes.tamanhoCampo == 0) this._controle.tamanhoCampo = 15;
		if (this._controle.tamanhoCampo < this._opcoes.precisao + 1) this._controle.tamanhoCampo = this._opcoes.precisao + 1;

		this._formataValorInicial();
	}

	_campoVirtual() {
		if ('value' in this._elemento) {
			let input = document.createElement('input');
			input.setAttribute('type', 'hidden');
			input.setAttribute('id', this._elemento.id);
			input.setAttribute('name', this._elemento.name);
			input.setAttribute('value', 0);
			this._elemento.parentNode.appendChild(input);

			this._elementoResultado = input;

			this._elemento.setAttribute('id', this._elemento.id + '_Mascara');
			this._elemento.setAttribute('name', this._elemento.name + '.Mascara');
			this._elemento.removeAttribute('pattern');
		}
	}

	_formataValorInicial() {
		if (!this._opcoes.valorAtual) {
			this._opcoes.valorAtual = parseFloat(this._recebaValorDoCampo());
			if (!this._opcoes.valorAtual) this._opcoes.valorAtual = 0;
			if (this._opcoes.valorAtual < 0) this._controle.negativo = true;
		}

		this._atribuiValorAoResultado((this._opcoes.valorAtual + '').replace('.', ','));

		let aFloat = (this._opcoes.valorAtual + '').split('.');

		if (aFloat[0]) this._controle.baseInteiro = aFloat[0] + '';

		if (aFloat[1]) this._controle.baseFracao = aFloat[1] + '';
		this._controle.baseFracao += '00000000000000000000';
		this._controle.baseFracao = this._controle.baseFracao.slice(0, this._opcoes.precisao);
		
		this._controle.baseValor = this._controle.baseInteiro + this._opcoes.separador + this._controle.baseFracao;
	}

	_controleElemento(elemento) {

		this._insiraValorNoCampo(this._opcoes.prefixo + this._formataNumero(this._controle.baseValor) + this._opcoes.sufixo);

		let that = this;
		let campoEmFoco = elemento,

			keydownHandler = function (e) {
				let tecla = (window.event) ? event.keyCode : e.which;
				let evento = (window.event) ? event : e;
				that._controle.baseValor = that._recebaValorDoCampo().replace(/\D/gim, '');
				let teclas = [9, 20, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 144];
				let teclasPontos = [110, 190, 188, 191, 194];

				if (tecla) {
					if (teclasPontos.find(element => element == tecla && that._controle.posicaoDecimal > 0 && that._controle.posicaoCursor == 0)) that._controle.posicaoCursor = that._opcoes.separador.length;
					if (!teclas.find(element => element == tecla) && !(('value' in campoEmFoco) && (tecla == 33 || tecla == 34))) event.preventDefault();
					if (tecla == 27) {
						that._controle.baseValor = '0';
						that._controle.baseInteiro = '0';
						that._controle.baseFracao = '00000000000000000000'.slice(0, that._opcoes.precisao);

						that._controle.posicaoCursor = that._controle.posicaoDecimal;
						if (that._opcoes.ehEstiloCalculadora) {
							that._controle.posicaoCursor = 0;
						}
					}
					if ('1234567890'.split('').find(element => element == evento.key)) {
						if (!that._opcoes.ehEstiloCalculadora) {
							if (that._controle.baseValor.length < that._controle.tamanhoCampo) {
								that._controle.baseValor += evento.key;
							}
						} else {
							if (that._controle.posicaoCursor == 0) {
								if (that._controle.baseInteiro == '') that._controle.baseInteiro = '0';
								let tamanho = (parseInt(that._controle.baseInteiro) + that._controle.baseFracao).length;
								if (that._controle.baseInteiro == '0') tamanho--;
								if (tamanho < that._controle.tamanhoCampo) {
									that._controle.baseInteiro += evento.key;
								}
							} else {
								if (that._controle.posicaoCursor < that._controle.posicaoDecimal) {
									let aAuxiliar = that._controle.baseFracao.split('');
									aAuxiliar[that._controle.posicaoCursor - 1] = evento.key;
									that._controle.baseFracao = aAuxiliar.join('');
								}
							}
							that._controle.baseValor = that._controle.baseInteiro + that._controle.baseFracao;

							if (that._controle.posicaoCursor > 0 && that._controle.posicaoCursor < that._controle.posicaoDecimal) that._controle.posicaoCursor++;
						}
					}
					if (tecla == 8 || tecla == 46) {
						if (!that._opcoes.ehEstiloCalculadora) {
							that._controle.baseValor = that._controle.baseValor.slice(0, -1);
						} else {
							if (that._controle.posicaoCursor == 0) {
								that._controle.baseInteiro = that._controle.baseInteiro.slice(0, -1);
							} else {
								let x = that._controle.baseFracao.split('');
								x[that._controle.posicaoCursor - 2] = '0';
								that._controle.baseFracao = x.join('');
							}

							if (that._controle.posicaoCursor > 0) {
								that._controle.posicaoCursor--;
								if (that._controle.posicaoCursor == that._opcoes.separador.length) that._controle.posicaoCursor = 0;
							}
							that._controle.baseValor = that._controle.baseInteiro + that._controle.baseFracao;
						}
					}
					if (tecla == 109 || tecla == 189) that._controle.negativo = true;
					if (tecla == 107 || tecla == 187) that._controle.negativo = false;
				}

				that._ajustaValorEntrada()
			},
			cursorHandler = function (e) {
				event.preventDefault();
				e.target.focus();
				if (!that._opcoes.ehEstiloCalculadora) {
					that._controle.posicaoCursor = that._controle.posicaoDecimal;
				}
				that._posicionaCursor(that._recebaValorDoCampo().length - that._opcoes.sufixo.length - that._controle.posicaoDecimal + that._controle.posicaoCursor);
			};

		campoEmFoco.type = 'tel';
		campoEmFoco.setAttribute('type', 'tel');
		campoEmFoco.style.textAlign = 'right';
		campoEmFoco.style.paddingRight = '3px';
		if (!'value' in campoEmFoco) campoEmFoco.setAttribute('contenteditable', 'true');

		campoEmFoco.addEventListener('keydown', keydownHandler, false);
		campoEmFoco.addEventListener('keyup', cursorHandler, false);
		campoEmFoco.addEventListener('focus', cursorHandler, false);
		campoEmFoco.addEventListener('mousedown', cursorHandler, false);

	}

	_ajustaValorEntrada() {
		let sinal = this._controle.negativo ? '-' : '';
		if (this._controle.baseValor === '') this._controle.baseValor = '0';
		let resultado = this._formataNumero(this._converteParaNumerico(this._controle.baseValor))
		this._insiraValorNoCampo(this._opcoes.prefixo + sinal + resultado + this._opcoes.sufixo);

		this._posicionaCursor(this._recebaValorDoCampo().length - this._opcoes.sufixo.length - this._controle.posicaoDecimal + this._controle.posicaoCursor);
	}

	_converteParaNumerico(valor) {
		if (!valor) valor = '0';
		let numStr = valor.replace(/\D/gim, '');

		let valorTratado = 0;
		if (this._opcoes.precisao === 0) {
			valorTratado = parseInt(numStr);
			if (isNaN(valorTratado)) valorTratado = 0;
		} else {
			valorTratado = parseFloat(numStr);
			if (isNaN(valorTratado)) valorTratado = 0.00;
			valorTratado = valorTratado / Math.pow(10, this._opcoes.precisao);
		}
		let valorReal = this._controle.negativo ? Math.abs(valorTratado) * -1 : valorTratado;
		this._opcoes.valorAtual = valorReal;
		this._atribuiValorAoResultado((valorReal + '').replace('.', ','));
		return valorTratado;
	}

	_atribuiValorAoResultado(valor) {
		if (!this._opcoes.ehVirtualizarCampo) return;
		if ('value' in this._elemento) {
			this._elementoResultado.value = valor;
			this._elementoResultado.dispatchEvent(new Event('change', { 'bubbles': true }));
		} else {
			this._elementoResultado.innerHTML = valor;
		}
	}

	_formataNumero = function (valor) {
		let retorno = '';

		if (isNaN(valor)) {
			valor = valor.replaceAll(this._opcoes.delimitador, '');
			valor = valor.replaceAll(this._opcoes.separador, '.');
		}

		valor = parseFloat(valor);

		if ((typeof valor) === 'number') {
			let aValor = valor.toFixed(this._opcoes.precisao).split('.');
			aValor[0] = '' + aValor[0].split(/(?=(?:...)*$)/).join(this._opcoes.delimitador).replaceAll('-' + this._opcoes.delimitador, '-');
			retorno = aValor.join(this._opcoes.separador);
		}

		return retorno;
	}


	_insiraValorNoCampo(valor) {
		if ('value' in this._elemento) {
			this._elemento.value = valor;
		} else {
			this._elemento.innerHTML = valor;
		}
	}

	_recebaValorDoCampo() {
		if ('value' in this._elemento) {
			return this._elemento.value;
		} else {
			return this._elemento.innerHTML;
		}
	}

	_posicionaCursor(posicao) {
		if (this._elemento && 'value' in this._elemento) {
			this._elemento.selectionStart = this._elemento.selectionEnd = posicao;
		} else {
			this._elemento.focus();
			let textNode = this._elemento.firstChild;
			let range = document.createRange();
			range.setStart(textNode, posicao);
			range.setEnd(textNode, posicao);
			let sel = window.getSelection();
			sel.removeAllRanges();
			sel.addRange(range);
		}
	}
}


String.prototype.replaceAll = function replaceAll(f, r) {
	if (!f || !r || f === '' || this === '' || (r.length > 0 && r.indexOf(f) >= 0)) return this;
	if (this.indexOf(f) === -1)
		return this.toString()
	else
		return this.replace(f, r).replaceAll(f, r)
}
