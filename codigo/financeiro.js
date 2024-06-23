
        // Constante recebendo url da API
        const url = 'http://localhost:5095/api/Financeiro';

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

        // Função para criar a tabela e preencher com os dados dos alunos
        async function createTable() {
            const data = await fetchData();

            // Criando os elementos da tabela
            const table = document.createElement('table');
            const thead = document.createElement('thead');
            const tbody = document.createElement('tbody');
            const trHead = document.createElement('tr');
            const th1 = document.createElement('th');
            const th2 = document.createElement('th');
            const th3 = document.createElement('th');

            // Definindo o conteúdo dos cabeçalhos
            th1.textContent = 'Cpf aluno:';
            th2.textContent = 'Valor:';
            th3.textContent = 'Situação pagamento:';

            // Adicionando os cabeçalhos à linha do cabeçalho
            trHead.appendChild(th1);
            trHead.appendChild(th2);
            trHead.appendChild(th3);

            // Adicionando a linha de cabeçalho ao thead
            thead.appendChild(trHead);

            // Adicionando os dados dos alunos ao corpo da tabela (tbody)
            data.dados.forEach(aluno => {
                const tr = document.createElement('tr');
                const tdCpf = document.createElement('td');
                const tdValor = document.createElement('td');
                const tdSituacao = document.createElement('td');

                tdCpf.textContent = aluno.cpf;
                tdValor.textContent = aluno.valorBoleto;
                tdSituacao.textContent = aluno.situacaoPagamento;

                tr.appendChild(tdCpf);
                tr.appendChild(tdValor);
                tr.appendChild(tdSituacao);

                tbody.appendChild(tr);
            });

            // Adicionando thead e tbody à tabela
            table.appendChild(thead);
            table.appendChild(tbody);

            // Adicionando a tabela ao corpo do documento (ou a algum outro contêiner)
            document.body.appendChild(table);

            // Imprimindo a estrutura para verificar
            console.log(document.body.innerHTML);
        }

        // Chamar a função para criar a tabela
        createTable();