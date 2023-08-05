using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System252 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component304,Component9,Component388> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component345>())
   {
    q+=1;
    var com = entity.Get<Component345>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component429>())
   {
    q+=1;
    var com = entity.Get<Component429>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component152>())
   {
    q+=1;
    var com = entity.Get<Component152>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component157>())
   {
    q+=1;
    var com = entity.Get<Component157>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
