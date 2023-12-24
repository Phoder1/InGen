// <auto-generated/>

using System;
using System.CodeDom.Compiler;
using JetBrains.Annotations;

namespace InGen.Target;

[GeneratedCode("InGen", "0.0.01")]
public partial class ChildContainer : 
    IContainer,
    IResolver<FooInChild>,
    IResolver<FooScopedInChild>
{
    public ChildContainer()
    {
        _rootScope = new Scope(this);
    }
    
    #region IContainer

    public override object Resolve(Type type, object id = null)
    {
        if (type == typeof(FooInChild))
            return Resolve<FooInChild>(id);

        if (type == typeof(FooScopedInChild))
            return Resolve<FooScopedInChild>(id);
        
        return base.Resolve(type, id);
    }

    public override IResult<object> TryResolve(Type type, [CanBeNull] object id = null)
    {
        if (type == typeof(FooInChild))
            return TryResolve<FooInChild>(id);

        if (type == typeof(FooScopedInChild))
            return TryResolve<FooScopedInChild>(id);
        
        return base.TryResolve(type, id);
    }

    public override IContainer CreateScope()
    {
        var scope = new Scope(this);
        _children.Add(scope);
        return scope;
    }

    public override void Dispose()
    {
        //Dispose all IDisposable fields

        base.Dispose();
    }

    #endregion
    
    #region Resolvers
    
    private FooInChild _fooInChild;

    FooInChild IResolver<FooInChild>.Resolve([CanBeNull] object id)
        => _fooInChild ??= new();

    FooScopedInChild IResolver<FooScopedInChild>.Resolve([CanBeNull] object id)
        => _rootScope.Resolve<FooScopedInChild>();
    
    #endregion
    
    public new class Scope : 
        Container.Scope,
        IResolver<FooInChild>,
        IResolver<FooScopedInChild>
    {
        public Scope(IContainer root) : base(root)
        {
            
        }
        
        #region IContainer

        public override object Resolve(Type type, object id = null)
        {
            if (type == typeof(FooInChild))
                return Resolve<FooInChild>(id);

            if (type == typeof(FooScopedInChild))
                return Resolve<FooScopedInChild>(id);
        
            return base.Resolve(type, id);
        }

        public override IResult<object> TryResolve(Type type, [CanBeNull] object id = null)
        {
            if (type == typeof(FooInChild))
                return TryResolve<FooInChild>(id);

            if (type == typeof(FooScopedInChild))
                return TryResolve<FooScopedInChild>(id);
        
            return base.TryResolve(type, id);
        }
        
        public override IContainer CreateScope()
        {
            var scope = new Scope(this);
            _children.Add(scope);
            return scope;
        }

        public override void Dispose()
        {
            //Dispose all IDisposable fields

            base.Dispose();
        }

        #endregion
        
        #region Resolvers

        FooInChild IResolver<FooInChild>.Resolve([CanBeNull] object id)
            => _root.Resolve<FooInChild>();

        private FooScopedInChild __InGenContainerTargetFooScopedInClass;

        FooScopedInChild IResolver<FooScopedInChild>.Resolve([CanBeNull] object id)
            => __InGenContainerTargetFooScopedInClass ??= new FooScopedInChild();
        
        #endregion
    }
}