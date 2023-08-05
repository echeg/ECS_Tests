using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System329 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component138> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component34>())
   {
    q+=1;
    var com = entity.Get<Component34>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component496>())
   {
    q+=1;
    var com = entity.Get<Component496>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component419>())
   {
    q+=1;
    var com = entity.Get<Component419>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component134>())
   {
    q+=1;
    var com = entity.Get<Component134>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
