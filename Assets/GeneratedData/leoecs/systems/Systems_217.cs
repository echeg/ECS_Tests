using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System217 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component303,Component179,Component55> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component71>())
   {
    q+=1;
    var com = entity.Get<Component71>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component169>())
   {
    q+=1;
    var com = entity.Get<Component169>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component297>())
   {
    q+=1;
    var com = entity.Get<Component297>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component2>())
   {
    q+=1;
    var com = entity.Get<Component2>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
