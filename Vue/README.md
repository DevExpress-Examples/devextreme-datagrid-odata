# Vue 3 + TypeScript + Vite + DevExtreme

Review the following file for the implementation overview: [Readme](../README.md).

## Start the Server

Start the [ODataServer](../ODataServer) before you run the application. This example is configured to access the ODataServer at port 5005. To change this configuration, update the following line: [HomeContent.vue#L9](/Vue/src/components/HomeContent.vue#L9)

## Build and Lint

- Install dependencies:
    ```sh
    npm install
    ```

- Build a production bundle:
    ```sh
    npm run build
    ```

- Run linter:
    ```sh
    npm run lint
    ```

- Start the dev server:
    ```sh
    npm run dev
    ```
    The dev server runs at the following URL: http://localhost:5173/

## Helpful Resources

You can learn more about Vue in the [Vue documentation](https://vuejs.org/guide/introduction.html).
You can learn more about Vite in the [Vite documentation](https://vite.dev/).
You can learn more about DevExtreme Vue components in the [DevExtreme Vue documentation](https://js.devexpress.com/Vue/).

If you still have questions, please contact us via the DevExpress [Support Center](https://supportcenter.devexpress.com/ticket/create).