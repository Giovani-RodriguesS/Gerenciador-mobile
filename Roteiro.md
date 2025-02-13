# 🎮 Desafio de Alteração no Math Game – Modo Game Over  

## 📌 Sobre o Math Game  
O **Math Game** é um jogo de operações matemáticas, onde o jogador deve acertar as respostas para ganhar pontos. Atualmente, a pontuação funciona da seguinte forma:  

✅ **Resposta correta:** +10 pontos  
❌ **Resposta errada:** -10 pontos  

Nosso desafio agora é modificar essa mecânica!  

---

## 🔧 Novo Requisito  
Agora, ao invés de perder apenas 10 pontos ao errar uma resposta, o jogador receberá uma tela de **"Game Over"** e terá a opção de reiniciar o jogo.  

---

## 🛠️ Roteiro para Implementação  

### 1️⃣ Identificar a lógica de verificação da resposta  
- Localize no código onde a resposta do jogador é verificada.  
- Atualmente, se a resposta estiver errada, são subtraídos 10 pontos.  

### 2️⃣ Substituir a subtração de pontos pelo Game Over  
- Remova a linha que subtrai 10 pontos da pontuação.  
- No lugar dela, chame uma função que exiba a tela de **"Game Over"**.  

### 3️⃣ Criar a Tela de "Game Over"  
- Criar uma nova página ou um modal com a mensagem **"Game Over"**.  
- Adicionar um botão **"Reiniciar"** para permitir que o jogador volte ao início do jogo.  

### 4️⃣ Implementar a lógica de reinício  
- Quando o jogador clicar no botão **"Reiniciar"**:  
  - A pontuação deve ser resetada.  
  - O jogo deve recomeçar da primeira questão.  
  - A tela de **"Game Over"** deve ser fechada.  

### 5️⃣ Testar a funcionalidade  
- Testar o jogo para garantir que o **Game Over** aparece corretamente ao errar uma resposta.  
- Verificar se o botão de reinício reseta o jogo corretamente.  


 
