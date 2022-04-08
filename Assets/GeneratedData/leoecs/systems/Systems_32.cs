using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System32 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component94,Component36,Component383> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component74>())
   {
    q+=1;
    var com = entity.Get<Component74>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component371>())
   {
    q+=1;
    var com = entity.Get<Component371>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component460>())
   {
    q+=1;
    var com = entity.Get<Component460>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component102>())
   {
    q+=1;
    var com = entity.Get<Component102>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
