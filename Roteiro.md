# 🎮 Desafio de Alteração no Math Game – Modo Game Over  

## 📌 Sobre o Math Game  
O Math Game é um jogo de perguntas e respostas que desafia o jogador a resolver adições matemáticas. A cada resposta correta, o jogador ganha pontos e avança no jogo. Atualmente, a pontuação funciona da seguinte forma:  

✅ **Resposta correta:** +10 pontos  
❌ **Resposta errada:** -10 pontos  

Nosso desafio agora é modificar essa mecânica!  

---

## 🔧 Novos Requisitos  
Sua missão agora será adicionar mais operações matemáticas às perguntas e implementar um botão de reinício.

---

## 🛠️ Roteiro para Implementação  

### 1️⃣ Expandir as Operações Matemáticas  
- Identificar onde as perguntas são geradas e modificar a lógica para incluir subtração, multiplicação e divisão.  
- Garantir que as novas operações sejam distribuídas de forma equilibrada.  
- Adaptar a verificação da resposta para considerar as novas operações.  

### 2️⃣ Implementar um Botão de Reinício  
- Criar um botão **"Reiniciar"** na interface do jogo.  
- Definir um evento para que, ao clicar, o jogo seja resetado.  

### 3️⃣ Ajustar a Lógica de Reinício  
- Quando o jogador clicar em **"Reiniciar"**:  
  - A pontuação deve ser redefinida para o valor inicial.  
  - O jogo deve voltar à primeira pergunta.  
  - Qualquer mensagem de erro ou **Game Over** deve ser removida.  

### 4️⃣ Testar as Novas Funcionalidades  
- Verificar se as novas operações estão sendo geradas corretamente.  
- Testar se o botão **"Reiniciar"** reseta o jogo sem erros.  
- Garantir que o jogo continua funcionando sem problemas após as mudanças.  
