
        // Constante recebendo url da API
        const url = 'http://localhost:5095/api/Financeiro';





        async function atualizarSituacaoPagamento(aluno, situacao) {
            try {
                // Atualiza apenas a situação de pagamento
                aluno.situacaoPagamento = situacao;
        
                const response = await fetch(url, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(aluno)
                });
        
                if (!response.ok) {
                    throw new Error(`Erro ao atualizar o aluno: ${response.statusText}`);
                }
        
                const data = await response.json();
                console.log('Aluno atualizado com sucesso:', data);
                return data;
            } catch (error) {
                console.error('Erro ao atualizar o aluno:', error);
                throw error;
            }
        }
        





        async function atualizarSituacaoPagamento(aluno, situacao) {
            try {
                // Atualiza apenas a situação de pagamento
                aluno.situacaoPagamento = situacao;
        
                const response = await fetch(url, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(aluno)
                });
        
                if (!response.ok) {
                    throw new Error(`Erro ao atualizar o aluno: ${response.statusText}`);
                }
        
                const data = await response.json();
                console.log('Aluno atualizado com sucesso:', data);
                return data;
            } catch (error) {
                console.error('Erro ao atualizar o aluno:', error);
                throw error;
            }
        }
        

        // Requisição GET da API
        async function fetchData() {
            try {
                const response = await fetch(url, {
                    method: 'GET',
                    mode: 'cors',
                    credentials: 'include'
                });

                if (!response.ok) {
                    throw new Error(`Erro na requisição: ${response.status}`);
                }

                const data = await response.json();
                console.log(data);
                return data;

            } catch (error) {
                console.error('Erro:', error);
                throw error;
            }
        }

        async function createTable() {
            try {
                const data = await fetchData();
        
                // Criando os elementos da tabela
                const table = document.createElement('table');
                const thead = document.createElement('thead');
                const tbody = document.createElement('tbody');
                const trHead = document.createElement('tr');
                const th1 = document.createElement('th');
                const th2 = document.createElement('th');
                const th3 = document.createElement('th');
                const th4 = document.createElement('th'); // Novo cabeçalho para a alteração
        
                // Definindo o conteúdo dos cabeçalhos
                th1.textContent = 'Cpf aluno:';
                th2.textContent = 'Valor:';
                th3.textContent = 'Situação pagamento:';
                th4.textContent = 'Alterar Situação:'; // Texto para o novo cabeçalho
        
                // Adicionando os cabeçalhos à linha do cabeçalho
                trHead.appendChild(th1);
                trHead.appendChild(th2);
                trHead.appendChild(th3);
                trHead.appendChild(th4); // Adicionar o novo cabeçalho à linha do cabeçalho
        
                // Adicionando a linha de cabeçalho ao thead
                thead.appendChild(trHead);
        
                // Adicionando os dados dos alunos ao corpo da tabela (tbody)
                data.dados.forEach(aluno => {
                    const tr = document.createElement('tr');
                    const tdCpf = document.createElement('td');
                    const tdValor = document.createElement('td');
                    const tdSituacao = document.createElement('td');
                    const tdAlterar = document.createElement('td'); // Nova célula para o campo de alteração
        
                    tdCpf.textContent = aluno.cpf;
                    tdValor.textContent = aluno.valorBoleto;
                    tdSituacao.textContent = aluno.situacaoPagamento;
        
                    // Criando um campo de seleção para alterar a situação de pagamento
                    const select = document.createElement('select');
                    const option1 = document.createElement('option');
                    const option2 = document.createElement('option');
        
                    option1.value = 'Pendente';
                    option1.textContent = 'Pendente';
        
                    option2.value = 'Pago';
                    option2.textContent = 'Pago';
        
                    select.appendChild(option1);
                    select.appendChild(option2);
        
                    // Definindo o valor atual como selecionado
                    select.value = aluno.situacaoPagamento;
        
                    select.addEventListener('change', async () => {
                        try {
                            // Atualizar a situação no backend
                            await atualizarSituacaoPagamento(aluno, select.value);
        
                            // Atualizar localmente na tabela (opcional)
                            tdSituacao.textContent = select.value;
                        } catch (error) {
                            console.error('Erro ao atualizar situação:', error);
                        }
                    });
        
                    tdAlterar.appendChild(select);
        
                    tr.appendChild(tdCpf);
                    tr.appendChild(tdValor);
                    tr.appendChild(tdSituacao);
                    tr.appendChild(tdAlterar); // Adicionar a nova célula à linha da tabela
        
                    tbody.appendChild(tr);
                });
        
                // Adicionando thead e tbody à tabela
                table.appendChild(thead);
                table.appendChild(tbody);
        
                // Adicionando a tabela ao corpo do documento (ou a algum outro contêiner)
                document.body.appendChild(table);
        
                // Imprimindo a estrutura para verificar
                console.log(document.body.innerHTML);
            } catch (error) {
                console.error('Erro ao criar tabela:', error);
            }
        }
        
        
        // Chamar a função para criar a tabela
        createTable();