using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System267 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component220> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component382>())
   {
    q+=1;
    var com = entity.Get<Component382>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component133>())
   {
    q+=1;
    var com = entity.Get<Component133>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component6>())
   {
    q+=1;
    var com = entity.Get<Component6>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component92>())
   {
    q+=1;
    var com = entity.Get<Component92>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
