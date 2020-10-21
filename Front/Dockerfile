FROM node:alpine as builder
ARG REACT_APP_MAIN_API_URL
ENV REACT_APP_MAIN_API_URL=$REACT_APP_MAIN_API_URL
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .

RUN npm run build

FROM node:alpine
RUN yarn global add serve
WORKDIR /app
COPY --from=builder /app/build .

EXPOSE 3000
CMD ["serve", "-p", "3000", "-s", "."]