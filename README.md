
>[!Important]
 > `Projeto:`
>- Dupla: Christian Varandas e Gabriel Barbosa
>- Turma: 3°Mtec Desenvolvimento de Jogos Digitais.
>- Escola: Etec Prof. Basilides de Godoy.
>- Sobre: Repositório para a documentação de uma cena utilizada para teste do Raycast, do unity.
>- Link: [(Projeto)](https://drive.google.com/drive/folders/1EityF9Wh-_7QN-PcnipeE2_DY5GMhS5X?usp=drive_link)
>- Video: Junto do arquivo no drive

## Sobre a cena

A nossa cena consiste em um cubo que vira junto da tela, na frente de cinco círculos enfileirados. Ao virar o mouse tanto na vertical quanto na horizontal, a câmera e o cubo viram junto. Clicando com o mouse em algum dos círculos, ele lança um raio, que se o acertar, o destrói. Caso erre, nada acontece.

## Explicação dos códigos

### Movimento

No início do código para movimento, ele cria classes para Rotação, Sensibilidade, e um valor máximo e mínimo para tela na vertical.

![image](https://github.com/user-attachments/assets/1e196407-0398-484b-8b6e-665a0a69881a)

- Void Start: Ele pega o rigidbody do objeto, e caso ele não seja nulo, ele pode mudar sua rotação.

![image](https://github.com/user-attachments/assets/05337117-2c98-4b00-8083-812219bcea78)

- Void Update: Caso o jogador mova no eixo X, ele se move multiplicando pela sensibilidade horizontal. E caso ele mova no eixo Y, ele multiplica pela sensibilidade vertical.

![image](https://github.com/user-attachments/assets/7681949b-fc3e-4c86-b9d7-26156f7c62dc)

### Raycast

No início do script, são criadas classes para o Raio, Acerto, Cor.

![image](https://github.com/user-attachments/assets/68a307bb-7daf-415d-a7a8-af6b992b4af1)


- Void Update: No update, ele mostra que se clicarmos no botão esquerdo do mouse, ele pega a posição do mesmo na tela, e chama o método Lancar.

![image](https://github.com/user-attachments/assets/57755112-12b7-4137-861e-32d4d74ac89d)

- Void Lancar: Nesse método, ele pega as classes do raio e cor. Primeiramente mostrando no console o ponto de origem e a direção do raio. Logo depois, se o alvo for acertado, ele transforma o objeto, e pega sua tag. Por fim, se a tag for "alvo", ele utiliza o comando para destruir o objeto, caso contrário, uma mensagem aparece no console avisando do erro.

![image](https://github.com/user-attachments/assets/f63a8d74-a7c9-4b3b-854c-5fe178e3909d)

## Avaliação da dupla

- Para não haver confusão na leitura: A avaliação de um integrante será escrita pelo outro, ou seja, onde estiver o nome de um, o outro integrante que escreveu.<br>
`Gabriel Barbosa`: Gabriel fez a parte dos códigos, enquanto eu o auxiliava com erros. Enquanto conversamos me ajudou muito com algumas dúvidas, fez um ótimo trabalho.<br>
`Christian Varandas`: Christian fez a parte da documentação e me ajudou bastante na parte dos código quando eu estava com dificuldade, fez um ótimo trabalho.
