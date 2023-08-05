using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System321 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component238> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component393>())
   {
    q+=1;
    var com = entity.Get<Component393>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component96>())
   {
    q+=1;
    var com = entity.Get<Component96>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component440>())
   {
    q+=1;
    var com = entity.Get<Component440>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component476>())
   {
    q+=1;
    var com = entity.Get<Component476>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
