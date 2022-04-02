using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System196 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component463> _p1;
EcsPool<Component343> _p2;
EcsPool<Component37> _p3;
EcsPool<Component187> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component463>().Inc<Component343>().Inc<Component37>().Inc<Component187>().End();
   _p1 = _world.GetPool<Component463>();
   _p2 = _world.GetPool<Component343>();
   _p3 = _world.GetPool<Component37>();
   _p4 = _world.GetPool<Component187>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
