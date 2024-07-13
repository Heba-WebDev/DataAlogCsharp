
<br />
<div align="center">
<a name="readme-top"></a>
  <h3 align="center">Welcome to APHKA API boilerplate 👷</h3>

  <p align="center">
    <br />
    <a href="https://drawsql.app/teams/kennielarkson-team/diagrams/hng11-aphka"><strong>Database Schema Design 🔗</strong></a>
    <br />
    <br />
    <a href="https://openapi-server.vercel.app/docs">Endpoints Docummentation 🔗</a>
    
  </p>
</div>

<br />
<br />

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
     <li><a href="#architecture-overview">Architecture Overview</a></li>
    <li><a href="#folder-structure">Folder Structure</a></li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

There are many great README templates available on GitHub; however, I didn't find one that really suited my needs so I created this enhanced one. I want to create a README template so amazing that it'll be the last one you ever need -- I think this is it.


<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With


* ExpressJs
* TypeScript
* PostgresSql
* Prisma
* Nodemailer

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Folder Structure 

```
|--- src
|    |--- presentation
|    |--- domain
|    |--- infrastructure
|    |--- features
|    |    |--- auth
|    |    |         |--- presentation
|    |    |         |--- domain
|    |    |         |--- infrastructure
|    |    |--- users
|    |    |--- organisations
|    |    |--- notifications
|    |    |--- messages
|    |    |--- payments
|    |    |--- emails
|    |--- config
|    |--- utils
|    |--- data
|    |--- server.ts
|    |--- app.ts
|--- .env
|--- example.env
|--- .gitignore
|--- package.json
|--- tsconfig.json
```
<p align="right">(<a href="#readme-top">back to top</a>)</p>


## _Architecture Overview_

The application is structured into three distinct layers:

### 1. Presentation Layer
  - handles external communication with various systems, including APIs, UI components, and HTTP/S requests.

### 2. Domain Layer
 -  encapsulates the core business rules, entities, data transfer objects (DTOs), validation logic, and use cases.

### 3. Infrastructure Layer

 - deals with external services and technical details.

#### Additionally:

 - The application follows the Vertical Slice technique, where each major feature or use case has its own dedicated folder structure.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* npm
  ```sh
  npm install npm@latest -g
  ```

* node version 20 or newer
  
  On Linux
  ```sh
  curl -fsSL https://fnm.vercel.app/install | bash 
  ```
  
  ```sh
  fnm use --install-if-missing 20
  ```
  
  On MacOs
  ```sh
  curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.7/install.sh | bash 
  ```
  
  ```sh
  nvm install 20 
  ```
  On Windows
   ```sh
  winget install Schniz.fnm
  ```
  
  ```sh
  fnm use --install-if-missing 20
  ```

### How to Use

1. Clone the repository.
   ```sh
   git clone
   ```
2. Install dependencies
   ```sh
   npm install
   ```
3. Create a .env file `.env` and add your credentials. A list of all env variables
   can be found at the root of the project inside `example.env`

4. Run the developement server using the following command
   ```sh
   npm run dev
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use this repository as a baseline to streamline starting an express project.


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are welcomed! NOTE: For major changes, please open an issue first to discuss what you would like to change.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b fix/typoReadme`)
3. Commit your Changes (`git commit -m 'Fixed a typo in the README file'`)
4. Push to the Branch (`git push origin fix/typoReadme`)
5. Open a Pull Request


<!-- COMMIT CHEATSHEET -->

### _Commit CheatSheet_

| Type     |                          | Description                                                                                                 |
| -------- | ------------------------ | ----------------------------------------------------------------------------------------------------------- |
| feat     | Features                 | A new feature                                                                                               |
| fix      | Bug Fixes                | A bug fix                                                                                                   |
| docs     | Documentation            | Documentation only changes                                                                                  |
| refactor | Code Refactoring         | A code change that neither fixes a bug nor adds a feature                                                   |
| perf     | Performance Improvements | A code change that improves performance                                                                     |
| test     | Tests                    | Adding missing tests or correcting existing tests                                                           |
| build    | Builds                   | Changes that affect the build system or external dependencies (example scopes: gulp, broccoli, npm)         |
| ci       | Continuous Integrations  | Changes to our CI configuration files and scripts (example scopes: Travis, Circle, BrowserStack, SauceLabs) |
| chore    | Chores                   | Other changes that don't modify , backend or test files                                                     |
| revert   | Reverts                  | Reverts a previous commit                                                                                   

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Heba Omar - [Twitter](https://twitter.com/jr_dev20) | [Linkedin](https://www.linkedin.com/in/heba-ismael-omar-645965252/) 

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

* [Inspired by Best-README-Template](https://github.com/othneildrew/Best-README-Template)
* [Built for HNG11 internship 2024](https://hng.tech)

<p align="right">(<a href="#readme-top">back to top</a>)</p>




