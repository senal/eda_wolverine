# up rabbitmq message broker and the console
run_rmq:
	@echo Starting RabbitMQ...
	docker-compose -f rmq_docker_compose.yml up -d
	@echo RabbitMQ Started!

# stop rabbitmq message broker and the console
stop_rmq:
	@echo Stopping RabbitMQ...
	docker-compose -f rmq_docker_compose.yml down
	@echo RabbitMQ Stopped!


run_sql:
	@echo Starting MSSQL server...
	docker-compose -f sql_docker_compose.yml up -d
	@echo MSSQL server started!

stop_sql:
	@echo Stopping MSSQL...
	docker-compose -f sql_docker_compose.yml down
	@echo MSSQL Stopped!