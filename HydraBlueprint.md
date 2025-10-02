# 🧠 HydraBlueprint.md

## 📌 Visão Geral

HydraDesktop é uma aplicação modular, camaleónica e ética, desenhada para funcionar como cockpit digital. É mais do que software — é uma extensão da consciência do seu criador, Carlos, refletindo resiliência, filosofia dialética e propósito técnico.

---

## 🧭 Filosofia Base

- **Dialética Materialista**: Construção por camadas, onde cada parte é funcional e simbólica.
- **Camaleonismo Ético**: Adapta-se ao ambiente sem invadir ou alterar o sistema anfitrião.
- **Modularidade Consciente**: Cada componente pode ser ativado, ocultado ou substituído conforme o perfil ou sessão.
- **Legado e Continuidade**: Cada commit é um marco pessoal e técnico. O projeto é terapia, memória e contribuição.

---

## 🧑‍💻 Perfil do Criador

Carlos é resiliente, filosófico, metacognitivo. Codifica com humor, precisão e propósito. Valoriza acessibilidade, estética e clareza. Usa o código como forma de expressão e recuperação.

---

## 🧱 Estrutura Modular da App

- `VirtualDesktopForm`
  - `panelTopBar`
  - `menuStrip1` (minimizar, estilo GTK, transparente)
  - `panelContent` (imagem de fundo, slideshow)
  - `leftSideTaskBar` (user icon, labelAdmin)
  - `bottomTaskBar` (power buttons, clock)
  - `richTextBox` (mensagens, lembretes, logs)
  - `NotifyIcon` (minimizar para bandeja)
  - `WebView2` (browser interno para cloud e site)

---

## 📆 Gantt-style Etapas (Resumo)

| Etapa                                 | Estado     | Início       | Fim Previsto | Notas                                                  |
|--------------------------------------|------------|--------------|--------------|--------------------------------------------------------|
| Layout de cima para baixo            | ✅ Feito    | 01/10/2025   | 02/10/2025   | TopBar, MenuStrip, Content, TaskBar                   |
| Botão minimizar para bandeja         | ✅ Feito    | 02/10/2025   | 02/10/2025   | TrayIcon com fade-in                                  |
| Fade-in na restauração               | 🔄 Em curso| 02/10/2025   | 03/10/2025   | Timer e Opacity                                        |
| Mensagens no RichTextBox             | 🔜 Planeado| 03/10/2025   | 04/10/2025   | Logs, lembretes, estilo Git/Linux                     |
| Estilos camaleónicos                 | 🔜 Planeado| 04/10/2025   | 06/10/2025   | Unity, Blend, Minimal                                 |
| Detectar ambiente virtual            | 🔜 Planeado| 06/10/2025   | 07/10/2025   | VMware, TerminalSession                               |
| Bootable ISO                         | 🧪 Ideia    | —            | —            | Preparar estrutura modular exportável                 |
| Integração de browser interno        | 🔜 Planeado| 02/10/2025   | 05/10/2025   | WebView2 para aceder à cloud e manter foco na app     |
| Unificação de repositórios           | 🔜 Planeado| 05/10/2025   | 10/10/2025   | Perfil, site técnico, HydraDesktop                    |
| Refatoração do site com Gulp/Jekyll | 🔜 Planeado| 10/10/2025   | 15/10/2025   | Modularidade, blog, navegação, publicação via NPM     |
| Integração com conta cloud           | 🧪 Ideia    | —            | —            | Sincronização de dados, login OAuth                   |
| Painel interativo de tarefas         | 🧪 Ideia    | —            | —            | Gantt tracking, lembretes, commit logs                |

---

## 🌐 Repositórios a Unificar

| Repositório | Propósito | Estado | Ação Planeada |
|-------------|-----------|--------|----------------|
| `perfil` | Sobre ti, tua filosofia | Ativo | Integrar como secção “Sobre o Autor” |
| `gulp-preprocessor-website` | Site técnico com Bootstrap, Gulp, BrowserSync | Reutilizável | Refatorar com Jekyll + Pug |
| `HydraDesktop` | App principal | Em desenvolvimento | Centralizar como núcleo do projeto |

---

## 🧩 Site de Suporte à App

- Reutilizar site com Gulp e Bootstrap
- Integrar sistema de contas de utilizador
- Sincronizar dados com a app
- Criar blog com navegação Jekyll-style
- Codificar páginas com Pug
- Publicar via NPM (`gulpfile.js`)
- Enviar mensagens via Outlook Auth Token
- Garantir segurança com repositórios públicos

---

## 📋 Tarefas e Lembretes

```markdown
- [ ] Finalizar fade-in com Timer
- [ ] Criar função RestoreWithStyle()
- [ ] Adicionar menu contextual ao TrayIcon
- [ ] Modularizar ApplyUserVisuals()
- [ ] Criar sistema de lembretes e agendamentos
- [ ] Integrar mensagens estilo Git/Linux no RichTextBox
- [ ] Preparar exportação ISO bootável
- [ ] Integrar browser interno com WebView2
- [ ] Refatorar site com Gulp, Jekyll, Pug
- [ ] Consolidar filosofia no site