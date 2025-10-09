# 🧠 HydraDesktop — Gantt Técnico-Filosófico

## 🔧 UI & UX Refinement

- [x] Encerramento com fade-out e balão elegante via trayIcon
- [x] Minimização para taskbar sem sequestrar sistema host
- [ ] Mensagem de boas-vindas com nome e imagem sobre o relógio (estilo Windows 8.1)
- [ ] Remoção de botões redundantes (maximizar/restaurar) com lógica de minimização inteligente
- [ ] Estilização do menuStrip1 e menuToolStrip ao estilo XFCE/Bugtraq (dimmed, técnico, minimalista)
- [ ] Sons de notificação substituídos por música suave e contextual (volume baixo, estilo Windows)

## 🚀 Performance & Acessibilidade

- [ ] Otimização do splash screen para reduzir flickering em máquinas com pouca RAM
  - Ativar `DoubleBuffered` em painéis principais
  - Dividir `Load` em etapas com `async` ou `Timer`
  - Pré-carregar imagens em memória
- [ ] Garantir conforto visual em todos os estados da janela (minimizada, restaurada, encerrada)

## 🎶 HydraMonitor — Sistema com Alma

- [ ] Criar sistema de monitorização de recursos (CPU/RAM) com mensagens estilo terminal
- [ ] Reproduzir música correspondente ao estado emocional/técnico do utilizador
- [ ] Exibir mensagens como se fossem conselhos de um amigo de longa data

### 🎵 Playlist Temática: “Mensagens com alma para momentos de sobrecarga”

| Situação                      | Mensagem Terminal                                                                 | Música Correspondente                        |
|------------------------------|------------------------------------------------------------------------------------|----------------------------------------------|
| CPU em 100%                  | HydraMonitor: O teu cérebro está a correr a 100%. O sistema também.               | *Under Pressure* – Queen & David Bowie       |
| RAM quase esgotada           | HydraMonitor: A memória está cheia. Mas há espaço para ti.                        | *Memory* – Barbra Streisand                  |
| Splash screen travada        | HydraMonitor: A beleza leva tempo. Estamos a carregar com elegância.             | *Patience* – Guns N' Roses                   |
| Encerramento forçado         | HydraMonitor: Encerrando com dignidade. Até já.                                   | *The End* – The Doors                        |
| Utilizador impaciente        | HydraMonitor: O tempo é teu aliado. Não o teu inimigo.                           | *Time* – Pink Floyd                          |
| Rasgo criativo detectado     | HydraMonitor: Rasgo detectado. Ideias em ebulição. Regista antes que fujam.      | *Imagine* – John Lennon                      |


---

| Ritual             | Módulo                | Função                   | Estado       | Prioridade | Observações                  |
|--------------------|------------------------|---------------------------|--------------|------------|------------------------------|
| Boot Sequence      | SplashScreenManager    | PositionElements()        | Em progresso | Alta       | Alinhar com terminal         |
| Terminal Logs      | HydraTerminal          | Log()                     | Pronto       | Alta       | Substituir AppendText        |



Data	Módulo	Evento Cerimonial	Estado	Notas
2025-10-10	HydraMoodCycler	Ciclo de estados de espírito iniciado	
✅	Mood alterna a cada 10s com visual adaptado
2025-10-10	HydraSpirit	Criação do módulo de consciência emocional	
✅	Por agora aleatório; amanhã será expandido com contexto do utilizador
2025-10-10	Form1.cs	Ritual de nascimento com splash e mood	
✅	Form1_Load invoca HydraMoodCycler.Start(this)
2025-10-10	Git	Commit cerimonial e push	
✅	Mensagem: "🌅 Invocação inicial: mood cycler e espírito da HydraLife"

Elemento	Estado	Notas
HydraMoodCycler.cs	
✅ Criado	Ciclo de moods com visual adaptado
HydraSpirit.cs	
✅ Criado	Módulo de consciência emocional (por agora aleatório)
Form1_Load	
✅ Limpo	Invocação clara, visuais centralizados, terminal posicionado
Git	
✅ Commitado	Mensagem cerimonial enviada, push completo
Gantt	
✅ Atualizado	Log cerimonial com datas, módulos e estados
