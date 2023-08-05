using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System326 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component196,Component135,Component245> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component145>())
   {
    q+=1;
    var com = entity.Get<Component145>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component284>())
   {
    q+=1;
    var com = entity.Get<Component284>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component100>())
   {
    q+=1;
    var com = entity.Get<Component100>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component452>())
   {
    q+=1;
    var com = entity.Get<Component452>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
