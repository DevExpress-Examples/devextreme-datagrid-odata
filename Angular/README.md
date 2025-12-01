# Angular DevExtreme Example

Review the following file for the implementation overview: [Readme](../README.md).

## Start the Server

Start the [ODataServer](../ODataServer) before you run the application. This example is configured to access the ODataServer at port 5005. To change this configuration, update the following line: [app.component.ts#L13](/Angular/src/app/app.component.ts#L13)

## Build and Lint

- Install dependencies:
    ```sh
    npm install
    ```

Start the dev server:
    ```sh
    npm start
    ```
    The dev server runs at the following URL: http://localhost:4200/

- Build a production bundle:
    ```sh
    npm run build
    ```

- Run linter:
    ```sh
    npm run lint
    ```

## Helpful Resources

Angular CLI docs: https://angular.dev/tools/cli
DevExtreme Angular docs: https://js.devexpress.com/Angular/Documentation

If you still have questions, please contact us via the DevExpress [Support Center](https://supportcenter.devexpress.com/ticket/create).