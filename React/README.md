# React + TypeScript + Vite + DevExtreme

Review the following file for the implementation overview: [Readme](../README.md).

## Start the Server

Start the [ODataServer](../ODataServer) before you run the application. This example is configured to access the ODataServer at port 5005. To change this configuration, update the following line: [App.tsx#L9](/React/src/App.tsx#L9)

## Build and Lint

- Install dependencies:
    ```sh
    npm install
    ```

- Start the dev server:
    ```sh
    npm run dev
    ```
    The dev server runs at the following URL: http://localhost:5173/

- Build a production bundle:
    ```sh
    npm run build
    ```

- Run linter:
    ```sh
    npm run lint
    ```

## Helpful Resources

React docs: https://react.dev/learn
Vite docs: https://vite.dev/
DevExtreme React docs: https://js.devexpress.com/React/Documentation

If you still have questions, please contact us via the DevExpress [Support Center](https://supportcenter.devexpress.com/ticket/create).