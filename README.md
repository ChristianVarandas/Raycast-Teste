
>[!Important]
 > `Projeto:`
>- Dupla: Christian Varandas e Gabriel Barbosa
>- Turma: 3°Mtec Desenvolvimento de Jogos Digitais.
>- Escola: Etec Prof. Basilides de Godoy.
>- Sobre: Repositório para a documentação de uma cena utilizada para teste do Raycast, do unity.
>- Link: [(Projeto)](https://drive.google.com/drive/folders/1EityF9Wh-_7QN-PcnipeE2_DY5GMhS5X?usp=drive_link)

## Sobre a cena

A nossa cena consiste em um cubo que vira junto da tela, na frente de cinco círculos enfileirados. Ao virar o mouse tanto na vertical quanto na horizontal, a câmera e o cubo viram junto. Clicando com o mouse em algum dos círculos, ele lança um raio, que se o acertar, o destrói. Caso erre, nada acontece.

## Explicação dos códigos

### Movimento

Abubluble

![image](https://github.com/user-attachments/assets/1e196407-0398-484b-8b6e-665a0a69881a)

- Void Start:

![image](https://github.com/user-attachments/assets/05337117-2c98-4b00-8083-812219bcea78)

- Void Update:

### Raycast

No início do script, são criadas classes para o Raio, Acerto, Cor e o Ponto de acerto.

![image](https://github.com/user-attachments/assets/936859bf-44d1-4d72-bfe1-e2788c5df16e)

- Void Update: No update, ele mostra que se clicarmos no botão esquerdo do mouse, ele pega a posição do mesmo na tela, e chama o método Lancar.

![image](https://github.com/user-attachments/assets/57755112-12b7-4137-861e-32d4d74ac89d)

- Void Lancar: Nesse método, ele pega as classes do raio e cor. Primeiramente mostrando no console o ponto de origem e a direção do raio. Logo depois, se o alvo for acertado (pegando a classe do ponto de acerto), ele transforma o objeto, e pega sua tag. Por fim, se a tag for "alvo", ele utiliza o comando para destruir o objeto, caso contrário, uma mensagem aparece no console avisando do erro.

![image](https://github.com/user-attachments/assets/f63a8d74-a7c9-4b3b-854c-5fe178e3909d)

## Avaliação da dupla
