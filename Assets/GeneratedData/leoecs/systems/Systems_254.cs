using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System254 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component137,Component325> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component205>())
   {
    q+=1;
    var com = entity.Get<Component205>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component163>())
   {
    q+=1;
    var com = entity.Get<Component163>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component272>())
   {
    q+=1;
    var com = entity.Get<Component272>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component247>())
   {
    q+=1;
    var com = entity.Get<Component247>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
