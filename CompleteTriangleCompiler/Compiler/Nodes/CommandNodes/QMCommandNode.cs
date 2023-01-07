namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to an if command
    /// </summary>
    public class QMCommandNode : ICommandNode
    {
        private ICommandNode command;

        /// <summary>
        /// The condition expression
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The then branch command
        /// </summary>
        public ICommandNode ThenCommand { get; }

        /// <summary>
        /// The else branch command
        /// </summary>
        public ICommandNode ElseCommand { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new if command node
        /// </summary>
        /// <param name="expression">The condition expression</param>
        /// <param name="command">The position in the code where the content associated with the node begins</param>


        public QMCommandNode(IExpressionNode expression, ICommandNode command)
        {
            Expression = expression;
            this.command = command;
        }
    }
}
